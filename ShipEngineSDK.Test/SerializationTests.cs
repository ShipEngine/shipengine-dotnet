namespace ShipEngineSDK.Test
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using Xunit;

    public class SerializationTests
    {
        public class WithGenericModel
        {
            public class WithReadOnlyProperties
            {
                [Fact]
                public void WhenSerializing_ItShouldIgnoreReadOnlyProperties()
                {
                    var batch = new Batch
                    {
                        BatchLabelsUrl = new OptionalLink { Href = "http://example.com/labels" },
                        BatchShipmentsUrl = new OptionalLink { Href = "http://example.com/shipments" }
                    };

                    var result = JsonSerializer.Serialize(batch, ShipEngineClient.JsonSerializerOptions);

                    Assert.Equal(@"{
  ""batch_labels_url"": {
    ""href"": ""http://example.com/labels""
  },
  ""batch_shipments_url"": {
    ""href"": ""http://example.com/shipments""
  }
}", result);
                }

                [Fact]
                public void WhenDeserializing_ItIncludeReadOnlyProperties()
                {
                    const string json = @"{
                  ""label_format"": ""png"",
                  ""label_layout"": ""letter"",
                  ""status"": ""open"",
                  ""batch_labels_url"": {
                    ""href"": ""http://example.com/labels""
                  },
                  ""batch_shipments_url"": {
                    ""href"": ""http://example.com/shipments""
                  }
                }";

                    var batch = JsonSerializer.Deserialize<Batch>(json, ShipEngineClient.JsonSerializerOptions);

                    Assert.Equal(LabelFormat.Png, batch.LabelFormat);
                    Assert.Equal(LabelLayout.Letter, batch.LabelLayout);
                    Assert.Equal(BatchStatus.Open, batch.Status);
                    Assert.Equal("http://example.com/labels", batch.BatchLabelsUrl.Href);
                    Assert.Equal("http://example.com/shipments", batch.BatchShipmentsUrl.Href);
                }
            }

            public class WithWriteOnlyProperties
            {
                [Fact]
                public void WhenSerializing_ItShouldIncludeWriteOnlyProperties()
                {
                    var pickup = new SchedulePickupRequestBody
                    {
                        PickupWindow = new PickupWindow
                        {
                            StartAt = new DateTimeOffset(2024, 7, 17, 12, 27, 35, TimeSpan.Zero),
                            EndAt = new DateTimeOffset(2024, 7, 19, 12, 27, 35, TimeSpan.Zero),
                        },
                        ContactDetails = new ContactDetails
                        {
                            Name = "John Doe",
                            Email = "jdoe@example.com",
                            Phone = "314-555-1234"
                        },
                        LabelIds = new List<string> { "se-1234567" }
                    };

                    var result = JsonSerializer.Serialize(pickup, ShipEngineClient.JsonSerializerOptions);

                    Assert.Equal(@"{
  ""contact_details"": {
    ""email"": ""jdoe@example.com"",
    ""name"": ""John Doe"",
    ""phone"": ""314-555-1234""
  },
  ""label_ids"": [
    ""se-1234567""
  ],
  ""pickup_window"": {
    ""end_at"": ""2024-07-19T12:27:35+00:00"",
    ""start_at"": ""2024-07-17T12:27:35+00:00""
  }
}", result);
                }

                [Fact]
                public void WhenDeserializing_ItShouldNotIncludeWriteOnlyProperties()
                {
                    var json = @"{
  ""label_download_type"": ""inline"",
  ""label_format"": ""png""
}";

                    var pickup = JsonSerializer.Deserialize<CreateReturnLabelRequestBody>(json, ShipEngineClient.JsonSerializerOptions);

                    Assert.Equal(LabelFormat.Png, pickup.LabelFormat);
                    Assert.Null(pickup.LabelDownloadType);
                }
            }
        }

        public class WithOneOfModel
        {
            [Fact]
            public void WhenSerializing_ItShouldSerializeShipmentId()
            {
                var body = new CalculateRatesRequestBody(new ShipmentIdRequest
                {
                    ShipmentId = "se-1234567"
                })
                {
                    RateOptions = new RateRequestBody
                    {
                        CarrierIds = new List<string> { "se-99999" }
                    }
                };

                var result = JsonSerializer.Serialize(body, ShipEngineClient.JsonSerializerOptions);

                Assert.Equal(@"{
  ""rate_options"": {
    ""carrier_ids"": [
      ""se-99999""
    ]
  },
  ""shipment_id"": ""se-1234567""
}", result);
            }

            [Fact]
            public void WhenSerializing_ItShouldSerializeShipment()
            {
                var body = new CalculateRatesRequestBody(new ShipmentRequest
                {
                    Shipment = new AddressValidatingShipment
                    {
                        CarrierId = "se-88888",
                        ServiceCode = "overnight",
                        ShipFrom = new ShippingAddress
                        {
                            AddressResidentialIndicator = AddressResidentialIndicator.No,
                            AddressLine1 = "123 Main St.",
                            CityLocality = "St. Louis",
                            CountryCode = "US",
                            Name = "John Doe",
                            Phone = "314-555-1234",
                            PostalCode = "63102",
                            StateProvince = "MO"
                        },
                        ShipTo = new ShippingAddressTo
                        {
                            AddressResidentialIndicator = AddressResidentialIndicator.Yes,
                            AddressLine1 = "456 Central",
                            CityLocality = "St. Louis",
                            CountryCode = "US",
                            Name = "Jane Doe",
                            Phone = "314-555-5678",
                            PostalCode = "63033",
                            StateProvince = "MO"
                        }
                    }
                })
                {
                    RateOptions = new RateRequestBody
                    {
                        CarrierIds = new List<string> { "se-99999" }
                    }
                };

                var result = JsonSerializer.Serialize(body, ShipEngineClient.JsonSerializerOptions);

                Assert.Equal(@"{
  ""rate_options"": {
    ""carrier_ids"": [
      ""se-99999""
    ]
  },
  ""shipment"": {
    ""carrier_id"": ""se-88888"",
    ""service_code"": ""overnight"",
    ""ship_from"": {
      ""address_line1"": ""123 Main St."",
      ""address_residential_indicator"": ""no"",
      ""city_locality"": ""St. Louis"",
      ""country_code"": ""US"",
      ""name"": ""John Doe"",
      ""phone"": ""314-555-1234"",
      ""postal_code"": ""63102"",
      ""state_province"": ""MO""
    },
    ""ship_to"": {
      ""address_line1"": ""456 Central"",
      ""address_residential_indicator"": ""yes"",
      ""city_locality"": ""St. Louis"",
      ""country_code"": ""US"",
      ""name"": ""Jane Doe"",
      ""phone"": ""314-555-5678"",
      ""postal_code"": ""63033"",
      ""state_province"": ""MO""
    }
  }
}", result);
            }

            [Fact]
            public void WhenDeserializing_ItShouldDeserializeShipmentId()
            {
                var json = @"{
  ""rate_options"": {
    ""carrier_ids"": [
      ""se-99999""
    ]
  },
  ""shipment_id"": ""se-1234567""
}";

                var result = JsonSerializer.Deserialize<CalculateRatesRequestBody>(json, ShipEngineClient.JsonSerializerOptions);

                Assert.NotNull(result.GetShipmentIdRequest());
                Assert.Contains("se-99999", result.RateOptions.CarrierIds);
            }

            [Fact]
            public void WhenDeserializing_ItShouldDeserializeShipment()
            {
                var json = @"{
  ""rate_options"": {
    ""carrier_ids"": [
      ""se-99999""
    ]
  },
  ""shipment"": {
    ""carrier_id"": ""se-88888""
  }
}";

                var result = JsonSerializer.Deserialize<CalculateRatesRequestBody>(json, ShipEngineClient.JsonSerializerOptions);

                Assert.NotNull(result.GetShipmentRequest());
                Assert.Contains("se-99999", result.RateOptions.CarrierIds);
            }
        }
    }
}