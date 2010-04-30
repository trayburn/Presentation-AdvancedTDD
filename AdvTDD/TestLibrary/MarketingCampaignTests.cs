using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Geocoding;
using AdvTDD;
using StructureMap;
using Rhino.Mocks;

namespace TestLibrary
{
    [TestFixture]
    public class MarketingCampaignTests
    {
        private IGeocoder _MockGeocoder;
        private Container container;

        [SetUp]
        public void Setup()
        {
            container = new Container();
            container.Configure(c =>
                {
                    c.For<MarketingCampaign>().Add<MarketingCampaign>();
                    _MockGeocoder = MockRepository.GenerateMock<IGeocoder>();
                    c.For<IGeocoder>().Add(_MockGeocoder);
                });
        }

        [TearDown]
        public void TearDown()
        {
            container.Dispose();
        }

        [Test]
        public void Should_Construct_With_Geocoder()
        {
            var camp = container.GetInstance<MarketingCampaign>();
            Assert.IsNotNull(camp);
        }

        [Test]
        public void Should_Geocode_Address_And_Get_Something()
        {
            _MockGeocoder.Expect(p => p.GeocodeAddress(null)).IgnoreArguments();
            var camp = container.GetInstance<MarketingCampaign>();
            camp.JudgeAndStorePatient(new Patient
            {
                Address = new Address
                {
                    Line1 = ""
                }
            });

            _MockGeocoder.VerifyAllExpectations();
        }
    }
}
