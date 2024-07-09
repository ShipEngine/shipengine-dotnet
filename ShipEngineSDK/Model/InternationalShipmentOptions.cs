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
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// Options for international shipments, such as customs declarations.
/// </summary>
//[DataContract(Name = "international_shipment_options")]
public partial class InternationalShipmentOptions
{

    /// <summary>
    /// The type of contents in this shipment.  This may impact import duties or customs treatment.  CLOVUS
    /// </summary>
    /// <value>The type of contents in this shipment.  This may impact import duties or customs treatment.</value>
    [JsonPropertyName("contents")]
    [JsonRequired]
    public PackageContents Contents { get; set; } = new();
    

    /// <summary>
    /// Indicates what to do if a package is unable to be delivered.  CLOVUS
    /// </summary>
    /// <value>Indicates what to do if a package is unable to be delivered.</value>
    [JsonPropertyName("non_delivery")]
    [JsonRequired]
    public NonDelivery NonDelivery { get; set; } = new();
    

    /// <summary>
    /// Specifies the supported terms of trade code (incoterms)  CLOVUS
    /// </summary>
    /// <value>Specifies the supported terms of trade code (incoterms)</value>
    [JsonPropertyName("terms_of_trade_code")]
    public AllowedIncoterms? TermsOfTradeCode { get; set; }
    /// <summary>
    /// Explanation for contents (required if the &#x60;contents&#x60; is provided as &#x60;other&#x60;)
    /// </summary>
    /// <value>Explanation for contents (required if the &#x60;contents&#x60; is provided as &#x60;other&#x60;)</value>
    [JsonPropertyName("contents_explanation")]
    public string ContentsExplanation { get; set; }

    /// <summary>
    /// Declaration statement to be placed on the commercial invoice
    /// </summary>
    /// <value>Declaration statement to be placed on the commercial invoice</value>
    [JsonPropertyName("declaration")]
    public string Declaration { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceAdditionalDetails
    /// </summary>
    [JsonPropertyName("invoice_additional_details")]
    public InvoiceAdditionalDetails InvoiceAdditionalDetails { get; set; }

    /// <summary>
    /// Gets or Sets ImporterOfRecord
    /// </summary>
    [JsonPropertyName("importer_of_record")]
    public ImporterOfRecords ImporterOfRecord { get; set; }

    /// <summary>
    /// Customs declarations for each item in the shipment. (Please provide this information under &#x60;products&#x60; inside &#x60;packages&#x60;)
    /// </summary>
    /// <value>Customs declarations for each item in the shipment. (Please provide this information under &#x60;products&#x60; inside &#x60;packages&#x60;)</value>
    [JsonPropertyName("customs_items")]
    [Obsolete]
    public List<CustomsItem> CustomsItems { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class InternationalShipmentOptions {\n");
        sb.Append("  Contents: ").Append(Contents).Append("\n");
        sb.Append("  ContentsExplanation: ").Append(ContentsExplanation).Append("\n");
        sb.Append("  NonDelivery: ").Append(NonDelivery).Append("\n");
        sb.Append("  TermsOfTradeCode: ").Append(TermsOfTradeCode).Append("\n");
        sb.Append("  Declaration: ").Append(Declaration).Append("\n");
        sb.Append("  InvoiceAdditionalDetails: ").Append(InvoiceAdditionalDetails).Append("\n");
        sb.Append("  ImporterOfRecord: ").Append(ImporterOfRecord).Append("\n");
        sb.Append("  CustomsItems: ").Append(CustomsItems).Append("\n");
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

