using NUnit.Framework;
using ShipEngine.Extensions;
using ShipEngine.Models.Package.Dto;
using ShipEngine.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using ShipEngine.Models;
using System.Linq;

// Using IEnumerable instead of list.
// https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/guidelines-for-collections?redirectedfrom=MSDN
namespace ShipEngine.Tests
{
    public class PackageService : BaseShipEngineServiceTest
    {


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
            throw new NUnit.Framework.IgnoreException("No bulk dixture available yet.");
            var p = new TrackPackageParams()
            {
                CarrierCode = "UPS",
                TrackingNumber = "ABC123"
            };


            var response = await MockShipEngineClient.Package.Track(p);

            Assert.That(response.Result.Messages, Is.InstanceOf<Messages>());
            Assert.That(response.Result.Information, Is.InstanceOf<Information>());
        }

        [Test]
        public async Task TrackPackageLowLevelBulkTest()
        {
            throw new NUnit.Framework.IgnoreException("No bulk dixture available yet.");
            List<TrackPackageParams> p = new()
            {

                new()
                {
                    CarrierCode = "UPS",
                    TrackingNumber = "ABC123"
                }
            };

            var responses = (await MockShipEngineClient.Package.Track(p)).ToList();
            var aResponse = responses[0];
            Assert.That(aResponse, Is.InstanceOf<TrackPackageResult>());
            Assert.That(aResponse.Result.Messages, Is.InstanceOf<Messages>());
            Assert.That(aResponse.Result.Information, Is.InstanceOf<Information>());
        }
    };

}
