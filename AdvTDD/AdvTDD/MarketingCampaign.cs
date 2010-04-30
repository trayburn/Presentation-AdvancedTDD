using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Geocoding;

namespace AdvTDD
{
    public class MarketingCampaign
    {
        private IGeocoder _geocoder;
        /// <summary>
        /// Initializes a new instance of the MarketingCampaign class.
        /// </summary>
        /// <param name="geocoder"></param>
        public MarketingCampaign(IGeocoder geocoder)
        {
            _geocoder = geocoder;
        }

        public void JudgeAndStorePatient(Patient p)
        {
            //var latlong = _geocoder.GeocodeAddress(p.Address);
        }
    }
}
