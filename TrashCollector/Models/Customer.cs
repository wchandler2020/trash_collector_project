using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {

        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Zipcode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }

        [Display(Name = "Please Choose your pickup date.")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } 
        public string DayOfWeek { get; set; }
        [DataType(DataType.Currency)]
        public double BillAmount { get; set; }
    }
}
