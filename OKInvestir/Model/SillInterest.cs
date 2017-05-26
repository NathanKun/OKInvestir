﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OKInvestir.Model
{
    public class SillInterest
    {
        public int Id { get; set; }
        [Required]
        public decimal Sill { get; set; }
        [Required]
        public decimal Interest { get; set; }
        //[Required]
        public int? ProductID { get; set; }
        /*[Required]
        public virtual Product Product { get; set; }*/
    }
}
