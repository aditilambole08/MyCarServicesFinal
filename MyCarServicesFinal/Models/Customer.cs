﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyCarServicesFinal.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
    }
}