﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        public double Balance { get; set; }

        public bool AccountActive { get; set; }

        public DateTime PickupDate { get; set; }


    }
}
