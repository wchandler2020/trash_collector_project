using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Invoice
    {
        [Key]
        public int INvoiceId { get; set; }
        public double InvoiceAmount { get; set; }
    }
}
