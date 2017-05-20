﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OKInvestir.UI;
using OKInvestir.Model;
using System.ComponentModel;
using System.Data.Entity;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;

namespace OKInvestir.ViewModel
{
    public class VMSimulation
    {
        private UISimulation View;
        public VMMain VMMain { get; set; }
        public List<Simulation> Simulations { get; set; }
        public List<Simulation> SimulationForBinding { get; set; }
        public BindingList<Simulation> blSimulation { get; set; }
        public List<Simulation> SimulationList { get; set; }


        public VMSimulation(VMMain VMMain, UISimulation View)
        {
            this.View = View;
            this.View.ViewModel = this;
            this.VMMain = VMMain;



        }

        public Model.TimeInterest FindTimeInterestSection()
        {
            DateTime StartDate = View.getValueStartDate();
            DateTime EndDate = View.getValueEndDate();
            int periode = (int)(EndDate - StartDate).TotalDays / 30;
            Model.TimeInterest time = new Model.TimeInterest();
            time.Time = 0;
            foreach (Model.TimeInterest timeI in VMMain.Product.TimeInterests)
            {
                if ((timeI.Time <= periode) && (timeI.Time >= time.Time))
                {
                    time.Time = timeI.Time;
                    time.Interest = timeI.Interest;
                    time.Id = timeI.Id;
                    time.ProductID = timeI.ProductID;
                    //time.Product = timeI.Product;
                }
            }
            return time;
        }

        public Model.SillInterest FindSillInterestSection(decimal Amount)
        {
            decimal amount = Amount;
            Model.SillInterest sill = new Model.SillInterest();
            sill.Sill = 0;
            foreach (Model.SillInterest sillI in VMMain.Product.SillInterests)
            {
                if ((sillI.Sill <= amount) && (sillI.Sill >= sill.Sill))
                {
                    sill.Sill = sillI.Sill;
                    sill.Id = sillI.Id;
                    sill.Interest = sillI.Interest;
                    //sill.Product = sillI.Product;
                    sill.ProductID = sillI.ProductID;
                }
            }
            return sill;
        }

        public int MinimumTimeSimulation()
        {
            Model.TimeInterest time = new Model.TimeInterest();
            time.Time = 0;
            int i = 0;
            foreach (Model.TimeInterest timeI in VMMain.Product.TimeInterests)
            {
                if (i == 0)
                {
                    time.Time = timeI.Time;
                }
                else
                {
                    if (timeI.Time < time.Time)
                    {
                        time.Time = timeI.Time;
                    }
                }
                i++;
            }
            return time.Time;
        }

        public void printBalance()
        {
            if (VMMain.Client.AccountList.Count > 0)
            {
                this.View.getLbValueBalance().Text = this.VMMain.Client.AccountList[0].Balance.ToString();
            }
            else
            {
                this.View.getLbValueBalance().Text = "No account";
            }
        }






        public Model.Simulation resultSimulation()
        {
            Model.Simulation simulation = new Model.Simulation();

            simulation.ClientId = VMMain.Client.Id;
            simulation.ProductId = VMMain.Product.Id;
            simulation.Price = View.getTbAmount();
            simulation.StartDate = View.getValueStartDate();
            simulation.EndDate = View.getValueEndDate();
            int periodeSimulation = (int)(simulation.EndDate - simulation.StartDate).TotalDays / 30;
            decimal InterestRateTime = FindTimeInterestSection().Interest;
            decimal InterestRateSill = FindSillInterestSection(simulation.Price).Interest;
            simulation.InterestRate = ((InterestRateSill + 100) * (InterestRateTime + 100)) / 100 - 100;
            simulation.SettlementPrice = simulation.Price * (100 + simulation.InterestRate) / 100;
            if (InterestRateTime == 0)
            {
                VMMain.UIMainForm.genMsgBox("For this product selected, the minimum holding periode have to be more than " + MinimumTimeSimulation() + " months.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                simulation.Price = 0;
            }

            if (simulation.Price != 0)
            {
                View.getLbValueAmount().Text = simulation.Price.ToString();
                View.getValuePeriode().Text = periodeSimulation.ToString() + " Months";

                View.getLbValueProductSelected().Text = VMMain.Product.Name;
                View.getLbValueInterestRate().Text = (simulation.InterestRate).ToString() + " %";
                View.GetLbValueSettlementPrice().Text = simulation.SettlementPrice.ToString();
            }
            return simulation;
        }

        public void saveSimulation(Model.Simulation simulation)
        {
            using (var context = new Model.Context())
            {
                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                context.Database.Initialize(force: false);  // connect to db
                context.Simulations.Add(simulation);
                try
                {
                    context.SaveChanges();  // save change
                    VMMain.UIMainForm.genMsgBox("Simulation saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception e)
                {
                    VMMain.HandleException(e, this.VMMain.UIMainForm);
                    VMMain.UIMainForm.genMsgBox("Fail to save the simulation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Cursor.Current = Cursors.Arrow;             // get back to normal cursor
                }
            }
        }

        public void getSimulation()
        {

            if (!VMMain.Client.Equals(null))
            {

                using (var context = new Model.Context())
                {
                    int ClientId = VMMain.Client.Id;
                    bool isSimulationFound = false;
                    Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                                                                //context.Database.Initialize(force: true);   // connect to db, it takes time
                    context.Database.Initialize(force: true);   // connect to db, it takes time
                    Simulations = context.Simulations.Where(u => u.ClientId == ClientId).ToList();
                    Cursor.Current = Cursors.Arrow;             // get back to normal cursor

                    SimulationForBinding = new List<Simulation>(Simulations);
                    blSimulation = new BindingList<Simulation>(SimulationForBinding);
                    this.View.getLboxSim().DataSource = blSimulation;
                    this.View.getLboxSim().DisplayMember = "LbInformation";


                }
            }
        }

        public void chooseSimulation(Simulation sim)
        {
            this.View.getValuePeriode().Text = ((int)(sim.EndDate - sim.StartDate).TotalDays / 30).ToString();
            this.View.getLbValueProductSelected().Text = sim.Product.Name;
            this.View.getLbValueAmount().Text = sim.Price.ToString();
            this.View.getLbValueInterestRate().Text = sim.InterestRate.ToString();
            this.View.GetLbValueSettlementPrice().Text = sim.SettlementPrice.ToString();

        }

        public void delectSimulaion(Simulation Sim)
        {
            using (var context = new Model.Context())
            {
                int SimId = Sim.Id;


                Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                                                            //context.Database.Initialize(force: true);   // connect to db, it takes time
                context.Database.Initialize(force: true);   // connect to db, it takes time
                Model.Simulation SimToRemove = context.Simulations.Where(u => u.Id == SimId).First();
                if (SimToRemove != null)
                {
                    context.Simulations.Attach(SimToRemove);
                    context.Simulations.Remove(SimToRemove);
                    context.SaveChanges();
                    VMMain.UIMainForm.genMsgBox("Simulation deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                Cursor.Current = Cursors.Arrow;             // get back to normal cursor

                SimulationForBinding = new List<Simulation>(Simulations);
                blSimulation = new BindingList<Simulation>(SimulationForBinding);
                this.View.getLboxSim().DataSource = blSimulation;
                this.View.getLboxSim().DisplayMember = "LbInformation";


            }
        }

        public void ExecuteSimulation(Model.Simulation Sim)
        {
            if (this.VMMain.Client.AccountList[0].Balance >= Sim.Price)
            {

                Model.BoughtProduct boughtP = new Model.BoughtProduct();
                //Enter infomations of simulation
                boughtP.BoughtStatus = 1;
                boughtP.Price = Sim.Price;

                //boughtP.Product = Sim.Product;
                boughtP.ProductId = Sim.ProductId;

                boughtP.SettlementPrice = Sim.SettlementPrice;

                boughtP.StartDate = Sim.StartDate;
                boughtP.EndDate = Sim.EndDate;
                boughtP.BuyingDate = DateTime.Today.Date;

                //boughtP.Client = this.VMMain.Client;
                boughtP.ClientId = this.VMMain.Client.Id;

                boughtP.FinalInterest = Sim.SettlementPrice - Sim.Price;

                //Save bought product
                using (var context = new Model.Context())
                {
                    Cursor.Current = Cursors.WaitCursor;        // waiting animation cursor
                    context.Database.Initialize(force: false);  // connect to db
                    List<Client> clients = context.Clients
                    .Include(c => c.AccountList)            // get related entities
                    .Include(bpl => bpl.BoughtProductList)
                    .Include("BoughtProductList.Product")
                    .Include("BoughtProductList.Product.TimeInterests")
                    .Include("BoughtProductList.Product.SillInterests")
                    .ToList();
                    Client clientSim = clients.Where(c => c.Id == VMMain.Client.Id).SingleOrDefault();
                    context.BoughtProducts.Add(boughtP);
                    clientSim.BoughtProductList.Add(boughtP);
                    clientSim.AccountList[0].Balance = clientSim.AccountList[0].Balance - Sim.Price;
                    //Console.Write(context.Clients.Find(VMMain.Client.Id).FirstName);

                    VMMain.Client.BoughtProductList.Add(boughtP);

                    try
                    {
                        context.SaveChanges();  // save change
                        VMMain.UIMainForm.genMsgBox("Simulation executed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.VMMain.Client.AccountList[0].Balance = this.VMMain.Client.AccountList[0].Balance - Sim.Price;

                    }
                    catch (Exception e)
                    {
                        VMMain.HandleException(e, this.VMMain.UIMainForm);
                        VMMain.UIMainForm.genMsgBox("Fail to execute the simulation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Cursor.Current = Cursors.Arrow;             // get back to normal cursor
                    }
                    //context.SaveChanges();
                }

            }
            else
            {
                VMMain.UIMainForm.genMsgBox("Balance not enough!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       



        

       




    }
}
