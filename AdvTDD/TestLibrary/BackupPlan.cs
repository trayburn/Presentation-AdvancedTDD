using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Geocoding;
using AdvTDD;
using StructureMap;

namespace TestLibrary
{

    [TestFixture]
    public class BackupPlan
    {
        [Test]
        public void Should_Remember_How_To_Work_With_SM()
        {
            using (StructureMap.Container container = new StructureMap.Container())
            {
                container.Configure(c =>
                {
                    c.For<ILatLong>().Add<LatLong>();
                });
                Console.WriteLine(container.GetInstance<ILatLong>().GetType().Name);
            }
        }
        [Test]
        public void Should_Remember_What_That_Math_Looks_Like()
        {
            double lat1 = 48.858001709;
            double lat2 = 48.8738;
            double long1 = 2.29460000992;
            double long2 = 2.295;

            double distance = Math.Sqrt(Math.Pow(Math.Abs(lat2 - lat1), 2) + Math.Pow(Math.Abs(long2 - long1), 2));
            Console.WriteLine(distance);
            double miles = distance * 60;
            Console.WriteLine(miles);
        }
    }
}
