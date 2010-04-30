using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding
{
    public interface IAddress
    {
        string Line1 { get; set; }
        string Line2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
    }
}
