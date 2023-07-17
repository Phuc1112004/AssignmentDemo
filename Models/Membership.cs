﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDemo.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
