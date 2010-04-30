using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding
{
    public class Geocoder
    {
        public ILatLong GeocodeAddress(IAddress address)
        {
            return new LatLong()
            {
                Latitude = 48.858001709,
                Longitude = 2.29460000992
            };
        }
    }
}
