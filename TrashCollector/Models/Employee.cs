using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Display(Name = "FIrst Name")]
        [Required]
        public string FirstName { get; set; }
        [Display(Name = "FIrst Name")]
        [Required]
        public string LastName { get; set; }
        [Required]
        [ForeignKey("Address")]
        public Address addresses { get; set; }
    }
}