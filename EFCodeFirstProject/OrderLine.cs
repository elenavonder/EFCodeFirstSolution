﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCodeFirstProject
{
    public class OrderLine
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Product { get; set; }
        [Column(TypeName = "decimal (11,2)")]
        public decimal Price { get; set; }
        public int Quality { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order {get; set;}
        public OrderLine()
        {

        }
    }
}
