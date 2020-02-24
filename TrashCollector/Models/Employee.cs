using Microsoft.AspNetCore.Identity;
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
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        public string ZipCode { get; set; }
        [ForeignKey("identityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser identityUser { get; set; }
    }
}