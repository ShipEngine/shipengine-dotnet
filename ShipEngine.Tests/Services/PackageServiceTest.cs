using NUnit.Framework;
using ShipEngine.ConvenienceMethods;
using ShipEngine.Models;
using ShipEngine.Models.Package.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Using IEnumerable instead of list.
// https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/guidelines-for-collections?redirectedfrom=MSDN
namespace ShipEngine.Tests
{
    public class PackageService : BaseShipEngineServiceTest
    {
        private static void AssertTrackPackageResult(TrackPackageResult r)
        {
            Assert.That(r, Is.InstanceOf<TrackPackageResult>());
            Assert.That(r.Messages, Is.InstanceOf<Messages>());
            Assert.That(r.Information, Is.InstanceOf<Information>());
        }

        [Test]
        public async Task PackageToConvenienceTest()
        {
            var information = await MockShipEngineClient.TrackPackage(
             packageId: "abc123"
            );
            var ev = information.Events.ToList()[0];
            Assert.That(ev.Status, Is.InstanceOf<Status>());
            Assert.That(information.EstimatedDelivery, Is.InstanceOf<DateTime>());
            Assert.That(information.TrackingNumber, Is.InstanceOf<string>());
            Assert.That(ev.CarrierDetailCode, Is.InstanceOf<string>());
            Assert.That(ev.CarrierStatusCode, Is.InstanceOf<string>());
            Assert.That(ev.Description, Has.Length.GreaterThan(0));
        }

        [Test]
        public async Task TrackPackageLowLevelTest()
        {
            var p = new TrackPackageParams()
            {
                CarrierCode = "UPS",
                TrackingNumber = "ABC123"
            };


            var response = await MockShipEngineClient.Package.Track(p);
            AssertTrackPackageResult(response.Result);
        }

        [Test]
        public async Task TrackPackageLowLevelBulkTest()
        {
            List<TrackPackageParams> p = new()
            {

                new()
                {
                    CarrierCode = "UPS",
                    TrackingNumber = "ABC123"
                }
            };

            var responses = (await MockShipEngineClient.Package.Track(p)).ToList();
            var aResponse = responses[0].Result;
            AssertTrackPackageResult(aResponse);
        }
    };

}