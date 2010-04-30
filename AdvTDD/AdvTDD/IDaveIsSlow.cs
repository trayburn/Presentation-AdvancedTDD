using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Geocoding;

namespace AdvTDD
{
    public interface IDaveIsSlow
    {
        bool EvaluatesPatientAndDistance(Patient p, double distance);
    }
}
