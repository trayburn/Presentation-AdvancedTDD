using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Geocoding;

namespace AdvTDD
{
    public class Address : IAddress
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
