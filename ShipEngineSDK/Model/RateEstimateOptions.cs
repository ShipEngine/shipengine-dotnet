/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others. 
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// RateEstimateOptions
/// </summary>
[DataContract(Name = "rate_estimate_options")]
public partial class RateEstimateOptions
{

    /// <summary>
    /// Gets or Sets Confirmation
    /// </summary>
    [JsonPropertyName("confirmation")]
    public string? Confirmation { get; set; }
    /// <summary>
    /// Gets or Sets AddressResidentialIndicator
    /// </summary>
    [JsonPropertyName("address_residential_indicator")]
    public string? AddressResidentialIndicator { get; set; }
    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("from_country_code")]
    public string FromCountryCode { get; set; }

    /// <summary>
    /// postal code
    /// </summary>
    /// <value>postal code</value>
    /// <example>
    /// 78756-3717
    /// </example>
    [JsonPropertyName("from_postal_code")]
    public string FromPostalCode { get; set; }

    /// <summary>
    /// from postal code
    /// </summary>
    /// <value>from postal code</value>
    /// <example>
    /// Austin
    /// </example>
    [JsonPropertyName("from_city_locality")]
    public string FromCityLocality { get; set; }

    /// <summary>
    /// From state province
    /// </summary>
    /// <value>From state province</value>
    /// <example>
    /// Austin
    /// </example>
    [JsonPropertyName("from_state_province")]
    public string FromStateProvince { get; set; }

    /// <summary>
    /// A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>A two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("to_country_code")]
    public string ToCountryCode { get; set; }

    /// <summary>
    /// postal code
    /// </summary>
    /// <value>postal code</value>
    /// <example>
    /// 78756-3717
    /// </example>
    [JsonPropertyName("to_postal_code")]
    public string ToPostalCode { get; set; }

    /// <summary>
    /// The city locality the package is being shipped to
    /// </summary>
    /// <value>The city locality the package is being shipped to</value>
    /// <example>
    /// Austin
    /// </example>
    [JsonPropertyName("to_city_locality")]
    public string ToCityLocality { get; set; }

    /// <summary>
    /// To state province
    /// </summary>
    /// <value>To state province</value>
    /// <example>
    /// Houston
    /// </example>
    [JsonPropertyName("to_state_province")]
    public string ToStateProvince { get; set; }

    /// <summary>
    /// The weight of the package
    /// </summary>
    /// <value>The weight of the package</value>
    [JsonPropertyName("weight")]
    public Weight Weight { get; set; }

    /// <summary>
    /// The dimensions of the package
    /// </summary>
    /// <value>The dimensions of the package</value>
    [JsonPropertyName("dimensions")]
    public Dimensions Dimensions { get; set; }

    /// <summary>
    /// ship date
    /// </summary>
    /// <value>ship date</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("ship_date")]
    public DateTime ShipDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class RateEstimateOptions {\n");
        sb.Append("  FromCountryCode: ").Append(FromCountryCode).Append("\n");
        sb.Append("  FromPostalCode: ").Append(FromPostalCode).Append("\n");
        sb.Append("  FromCityLocality: ").Append(FromCityLocality).Append("\n");
        sb.Append("  FromStateProvince: ").Append(FromStateProvince).Append("\n");
        sb.Append("  ToCountryCode: ").Append(ToCountryCode).Append("\n");
        sb.Append("  ToPostalCode: ").Append(ToPostalCode).Append("\n");
        sb.Append("  ToCityLocality: ").Append(ToCityLocality).Append("\n");
        sb.Append("  ToStateProvince: ").Append(ToStateProvince).Append("\n");
        sb.Append("  Weight: ").Append(Weight).Append("\n");
        sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
        sb.Append("  Confirmation: ").Append(Confirmation).Append("\n");
        sb.Append("  AddressResidentialIndicator: ").Append(AddressResidentialIndicator).Append("\n");
        sb.Append("  ShipDate: ").Append(ShipDate).Append("\n");
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

