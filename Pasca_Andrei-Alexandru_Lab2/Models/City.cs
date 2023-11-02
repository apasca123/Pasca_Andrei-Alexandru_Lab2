﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasca_Andrei_Alexandru_Lab2.Models
{
    public class City
    {
        public int ID { get; set; }
        public string? CityName { get; set; }
        public ICollection<Customer>? Customers { get; set; }
    }
}
