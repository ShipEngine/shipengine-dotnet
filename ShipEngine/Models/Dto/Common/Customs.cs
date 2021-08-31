using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;

namespace ShipEngineSDK.Common
{
    /// <summary>
    /// Customs information associated with rates/shipments
    /// </summary>
    public class Customs
    {
        /// <summary>
        /// The type of contents in this shipment. This may impact import duties or customs treatment.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PackageContents Contents { get; set; }

        /// <summary>
        /// Indicates what to do if a package is unable to be delivered.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public NonDelivery NonDelivery { get; set; }

        /// <summary>
        /// Customs declarations for each item in the shipment.
        /// </summary>
        public List<CustomsItem> CustomsItems { get; set; }
    }

    /// <summary>
    /// Customs Item in shipment.
    /// </summary>
    public class CustomsItem
    {
        /// <summary>
        /// A description of the item
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// The quantity of this item in the shipment.
        /// </summary>
        public double? Quantity { get; set; }

        /// <summary>
        /// The declared customs value of each item
        /// </summary>
        public MonetaryValue? Value { get; set; }

        /// <summary>
        /// The Harmonized Tariff Code of this item.
        /// </summary>
        public string? HarmonizedTariffCode { get; set; }

        /// <summary>
        /// The two-letter ISO 3166-1 country code where this item originated
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Country? CountryOfOrigin { get; set; }

        /// <summary>
        /// Unit that the customs item is measured in.
        /// </summary>
        public string? UnitOfMeasure { get; set; }

        /// <summary>
        /// The SKU (Stock Keeping Unit) of the customs item
        /// </summary>
        public string? Sku { get; set; }

        /// <summary>
        /// Description of the Custom Item's SKU
        /// </summary>
        public string? SkuDescription { get; set; }
    }
}