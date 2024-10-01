﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        //[ForeignKey("ProductVariant")]
       // public int ProductVariantId { get; set; }
        //public virtual ProductVariant ProductVariant { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int Quality { get; set; }
        public double UnitPrice { get; set; }
        public double Subtotal { get; set; }



    }
}
