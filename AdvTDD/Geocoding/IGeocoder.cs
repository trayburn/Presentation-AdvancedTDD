using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geocoding
{
    public interface IGeocoder
    {
        ILatLong GeocodeAddress(IAddress address);
    }
}
