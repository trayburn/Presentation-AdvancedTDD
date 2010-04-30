using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding
{
    public interface ILatLong
    {
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
}
