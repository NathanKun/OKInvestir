﻿namespace OKInvestir.UI
{
    partial class UIDashboard
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pnClient = new System.Windows.Forms.Panel();
            this.lbNbClient = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnProduct = new System.Windows.Forms.Panel();
            this.lbNbPdt = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnProductSold = new System.Windows.Forms.Panel();
            this.lbNbPdtSold = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTurnover = new System.Windows.Forms.Panel();
            this.lbTurnover = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ttPanels = new System.Windows.Forms.ToolTip(this.components);
            this.lbTransactionAmount = new System.Windows.Forms.Label();
            this.chartTA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnProductSold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnTurnover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTA)).BeginInit();
            this.SuspendLayout();
            // 
            // pnClient
            // 
            this.pnClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pnClient.Controls.Add(this.lbNbClient);
            this.pnClient.Controls.Add(this.pictureBox4);
            this.pnClient.Location = new System.Drawing.Point(37, 32);
            this.pnClient.Name = "pnClient";
            this.pnClient.Size = new System.Drawing.Size(160, 111);
            this.pnClient.TabIndex = 0;
            this.ttPanels.SetToolTip(this.pnClient, "Numbers of client");
            // 
            // lbNbClient
            // 
            this.lbNbClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbNbClient.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNbClient.ForeColor = System.Drawing.Color.White;
            this.lbNbClient.Location = new System.Drawing.Point(0, 83);
            this.lbNbClient.Name = "lbNbClient";
            this.lbNbClient.Size = new System.Drawing.Size(160, 28);
            this.lbNbClient.TabIndex = 3;
            this.lbNbClient.Text = "nb of clt";
            this.lbNbClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttPanels.SetToolTip(this.lbNbClient, "Numbers of client");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OKInvestir.Properties.Resources.user;
            this.pictureBox4.Location = new System.Drawing.Point(40, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.ttPanels.SetToolTip(this.pictureBox4, "Numbers of client");
            // 
            // pnProduct
            // 
            this.pnProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pnProduct.Controls.Add(this.lbNbPdt);
            this.pnProduct.Controls.Add(this.pictureBox3);
            this.pnProduct.Location = new System.Drawing.Point(233, 32);
            this.pnProduct.Name = "pnProduct";
            this.pnProduct.Size = new System.Drawing.Size(160, 111);
            this.pnProduct.TabIndex = 1;
            this.ttPanels.SetToolTip(this.pnProduct, "Numbers of products availble");
            // 
            // lbNbPdt
            // 
            this.lbNbPdt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbNbPdt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNbPdt.ForeColor = System.Drawing.Color.White;
            this.lbNbPdt.Location = new System.Drawing.Point(0, 83);
            this.lbNbPdt.Name = "lbNbPdt";
            this.lbNbPdt.Size = new System.Drawing.Size(160, 28);
            this.lbNbPdt.TabIndex = 4;
            this.lbNbPdt.Text = "nb of pdt";
            this.lbNbPdt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttPanels.SetToolTip(this.lbNbPdt, "Numbers of products availble");
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OKInvestir.Properties.Resources.product;
            this.pictureBox3.Location = new System.Drawing.Point(40, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 74);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.ttPanels.SetToolTip(this.pictureBox3, "Numbers of products availble");
            // 
            // pnProductSold
            // 
            this.pnProductSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pnProductSold.Controls.Add(this.lbNbPdtSold);
            this.pnProductSold.Controls.Add(this.pictureBox1);
            this.pnProductSold.Location = new System.Drawing.Point(430, 32);
            this.pnProductSold.Name = "pnProductSold";
            this.pnProductSold.Size = new System.Drawing.Size(160, 111);
            this.pnProductSold.TabIndex = 1;
            this.ttPanels.SetToolTip(this.pnProductSold, "Numbers of products sold");
            // 
            // lbNbPdtSold
            // 
            this.lbNbPdtSold.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbNbPdtSold.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNbPdtSold.ForeColor = System.Drawing.Color.White;
            this.lbNbPdtSold.Location = new System.Drawing.Point(0, 83);
            this.lbNbPdtSold.Name = "lbNbPdtSold";
            this.lbNbPdtSold.Size = new System.Drawing.Size(160, 28);
            this.lbNbPdtSold.TabIndex = 4;
            this.lbNbPdtSold.Text = "nb of pdt sold";
            this.lbNbPdtSold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttPanels.SetToolTip(this.lbNbPdtSold, "Numbers of products sold");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OKInvestir.Properties.Resources.sell;
            this.pictureBox1.Location = new System.Drawing.Point(40, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.ttPanels.SetToolTip(this.pictureBox1, "Numbers of products sold");
            // 
            // pnTurnover
            // 
            this.pnTurnover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.pnTurnover.Controls.Add(this.lbTurnover);
            this.pnTurnover.Controls.Add(this.pictureBox2);
            this.pnTurnover.Location = new System.Drawing.Point(627, 32);
            this.pnTurnover.Name = "pnTurnover";
            this.pnTurnover.Size = new System.Drawing.Size(160, 111);
            this.pnTurnover.TabIndex = 1;
            this.ttPanels.SetToolTip(this.pnTurnover, "Turnover");
            // 
            // lbTurnover
            // 
            this.lbTurnover.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTurnover.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurnover.ForeColor = System.Drawing.Color.White;
            this.lbTurnover.Location = new System.Drawing.Point(0, 83);
            this.lbTurnover.Name = "lbTurnover";
            this.lbTurnover.Size = new System.Drawing.Size(160, 28);
            this.lbTurnover.TabIndex = 4;
            this.lbTurnover.Text = "turnover";
            this.lbTurnover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttPanels.SetToolTip(this.lbTurnover, "Turnover");
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OKInvestir.Properties.Resources.turnover;
            this.pictureBox2.Location = new System.Drawing.Point(40, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.ttPanels.SetToolTip(this.pictureBox2, "Turnover");
            // 
            // ttPanels
            // 
            this.ttPanels.AutoPopDelay = 5000;
            this.ttPanels.InitialDelay = 1;
            this.ttPanels.ReshowDelay = 100;
            // 
            // lbTransactionAmount
            // 
            this.lbTransactionAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.lbTransactionAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTransactionAmount.ForeColor = System.Drawing.Color.White;
            this.lbTransactionAmount.Location = new System.Drawing.Point(37, 440);
            this.lbTransactionAmount.Name = "lbTransactionAmount";
            this.lbTransactionAmount.Size = new System.Drawing.Size(750, 28);
            this.lbTransactionAmount.TabIndex = 4;
            this.lbTransactionAmount.Text = "Transaction amount";
            this.lbTransactionAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttPanels.SetToolTip(this.lbTransactionAmount, "Numbers of client");
            // 
            // chartTA
            // 
            this.chartTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.chartTA.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartTA.ChartAreas.Add(chartArea1);
            this.chartTA.Location = new System.Drawing.Point(37, 177);
            this.chartTA.Name = "chartTA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Name = "Transaction amount";
            this.chartTA.Series.Add(series1);
            this.chartTA.Size = new System.Drawing.Size(750, 277);
            this.chartTA.TabIndex = 2;
            this.chartTA.Text = "Transaction amount";
            // 
            // UIDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(232)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.lbTransactionAmount);
            this.Controls.Add(this.chartTA);
            this.Controls.Add(this.pnTurnover);
            this.Controls.Add(this.pnProductSold);
            this.Controls.Add(this.pnProduct);
            this.Controls.Add(this.pnClient);
            this.Name = "UIDashboard";
            this.Size = new System.Drawing.Size(824, 500);
            this.pnClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnProductSold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnTurnover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnProduct;
        private System.Windows.Forms.Panel pnProductSold;
        private System.Windows.Forms.Panel pnTurnover;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbNbClient;
        private System.Windows.Forms.Label lbNbPdt;
        private System.Windows.Forms.Label lbNbPdtSold;
        private System.Windows.Forms.Label lbTurnover;
        private System.Windows.Forms.ToolTip ttPanels;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTA;
        private System.Windows.Forms.Label lbTransactionAmount;
    }
}
