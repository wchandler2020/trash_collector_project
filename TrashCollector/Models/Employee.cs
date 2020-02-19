using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Employees
    {   
        [Key]
        public int Id { get; set; }
        public int zipCode { get; set; }


    }
}
