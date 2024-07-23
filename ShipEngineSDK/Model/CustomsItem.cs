// <auto-generated />
// DO NOT MODIFY THIS FILE

// Changes can be made in a corresponding partial file, or by changing
// the template in <root>/generation/templates and generating the class again.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// The customs declaration for a single item in the shipment.
/// </summary>
public partial class CustomsItem
{

    /// <summary>
    /// A string that uniquely identifies the customs item
    /// </summary>
    /// <value>A string that uniquely identifies the customs item</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("customs_item_id"), JsonInclude]
    public string? CustomsItemId { get; set; }

    /// <summary>
    /// The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) where this item originated 
    /// </summary>
    /// <value>The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) where this item originated </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("country_of_origin"), JsonPropertyOrder(2)]
    public string? CountryOfOrigin { get; set; }

    /// <summary>
    /// A description of the item
    /// </summary>
    /// <value>A description of the item</value>
    [JsonPropertyName("description"), JsonPropertyOrder(3)]
    public string? Description { get; set; }

    /// <summary>
    /// The [Harmonized Tariff Code](https://en.wikipedia.org/wiki/Harmonized_System) of this item.
    /// </summary>
    /// <value>The [Harmonized Tariff Code](https://en.wikipedia.org/wiki/Harmonized_System) of this item.</value>
    /// <example>
    /// 3926.1
    /// </example>
    [JsonPropertyName("harmonized_tariff_code"), JsonPropertyOrder(4)]
    public string? HarmonizedTariffCode { get; set; }

    /// <summary>
    /// The quantity of this item in the shipment.
    /// </summary>
    /// <value>The quantity of this item in the shipment.</value>
    [JsonPropertyName("quantity"), JsonPropertyOrder(5)]
    public int? Quantity { get; set; }

    /// <summary>
    /// The SKU (Stock Keeping Unit) of the customs item
    /// </summary>
    /// <value>The SKU (Stock Keeping Unit) of the customs item</value>
    [JsonPropertyName("sku"), JsonPropertyOrder(6)]
    public string? Sku { get; set; }

    /// <summary>
    /// Description of the Custom Item&#39;s SKU
    /// </summary>
    /// <value>Description of the Custom Item&#39;s SKU</value>
    [JsonPropertyName("sku_description"), JsonPropertyOrder(7)]
    public string? SkuDescription { get; set; }

    /// <summary>
    /// Gets or Sets UnitOfMeasure
    /// </summary>
    [JsonPropertyName("unit_of_measure"), JsonPropertyOrder(8)]
    public string? UnitOfMeasure { get; set; }

    /// <summary>
    /// The monetary amount, in the specified currency.
    /// </summary>
    /// <value>The monetary amount, in the specified currency.</value>
    [JsonPropertyName("value"), JsonPropertyOrder(9)]
    public double? Value { get; set; }

    /// <summary>
    /// The currencies that are supported by ShipEngine are the ones that specified by ISO 4217: https://www.iso.org/iso-4217-currency-codes.html 
    /// </summary>
    /// <value>The currencies that are supported by ShipEngine are the ones that specified by ISO 4217: https://www.iso.org/iso-4217-currency-codes.html </value>
    [JsonPropertyName("value_currency"), JsonPropertyOrder(10)]
    public string? ValueCurrency { get; set; }

    /// <summary>
    /// The item weight
    /// </summary>
    /// <value>The item weight</value>
    [JsonPropertyName("weight"), JsonPropertyOrder(11)]
    public Weight? Weight { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CustomsItem {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  CustomsItemId: ").Append(CustomsItemId).Append("\n");
        sb.Append("  CountryOfOrigin: ").Append(CountryOfOrigin).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  HarmonizedTariffCode: ").Append(HarmonizedTariffCode).Append("\n");
        sb.Append("  Quantity: ").Append(Quantity).Append("\n");
        sb.Append("  Sku: ").Append(Sku).Append("\n");
        sb.Append("  SkuDescription: ").Append(SkuDescription).Append("\n");
        sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  ValueCurrency: ").Append(ValueCurrency).Append("\n");
        sb.Append("  Weight: ").Append(Weight).Append("\n");
#pragma warning restore CS0612 // Type or member is obsolete
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson(JsonSerializerOptions options)
    {
        return JsonSerializer.Serialize(this, options);
    }

}