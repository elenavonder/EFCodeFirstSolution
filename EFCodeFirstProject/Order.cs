using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCodeFirstProject
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Description { get; set; }
        [Column (TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Created { get; set; }
        public int CustomerId { get; set; }
        //customer instance for the order 
        //virtual orders are not in the database. This is to make a FK
        public virtual Customer Customer { get; set; }

        public Order()
        {

        }
    }
}
