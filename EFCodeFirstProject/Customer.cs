using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCodeFirstProject
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] //stating Name cannot be null
        [StringLength(30)] //stating how long Name can be
        public string Name { get; set; }
        [Required]//Code cannot be null
        [StringLength(30)] //how many characters Code can have
        public string Code { get; set; }
        public bool Active { get; set; }
        [Column(TypeName = "decimal(11,2)")] //telling SQL what the decimal total should be instead of SQL picking
        public decimal Sales { get; set; }//decimal used for currency
        [Column(TypeName = "datetime")]//for a standard date and time in SQL
        public DateTime Created { get; set; }

        public Customer()
        {

        }

    }
}
