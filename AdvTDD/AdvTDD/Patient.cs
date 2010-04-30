using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Geocoding;

namespace AdvTDD
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}