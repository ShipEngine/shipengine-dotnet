/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others.  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


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
/// An update UPS settings request body
/// </summary>
//[DataContract(Name = "update_ups_settings_request_body")]
public partial class UpdateUpsSettingsRequestBody
{

    /// <summary>
    /// Gets or Sets PickupType  CLOVUS
    /// </summary>
    [JsonPropertyName("pickup_type")]
    public UpsPickupType? PickupType { get; set; }
    /// <summary>
    /// Gets or Sets MailInnovationsEndorsement  CLOVUS
    /// </summary>
    [JsonPropertyName("mail_innovations_endorsement")]
    public AncillaryServiceEndorsement? MailInnovationsEndorsement { get; set; }
    /// <summary>
    /// nickname
    /// </summary>
    /// <value>nickname</value>
    [JsonPropertyName("nickname")]
    public string Nickname { get; set; }

    /// <summary>
    /// Indicates if this is the primary UPS account
    /// </summary>
    /// <value>Indicates if this is the primary UPS account</value>
    [JsonPropertyName("is_primary_account")]
    public bool IsPrimaryAccount { get; set; }

    /// <summary>
    /// The use carbon neutral shipping program
    /// </summary>
    /// <value>The use carbon neutral shipping program</value>
    [JsonPropertyName("use_carbon_neutral_shipping_program")]
    public bool UseCarbonNeutralShippingProgram { get; set; }

    /// <summary>
    /// The use ground freight pricing
    /// </summary>
    /// <value>The use ground freight pricing</value>
    [JsonPropertyName("use_ground_freight_pricing")]
    public bool UseGroundFreightPricing { get; set; }

    /// <summary>
    /// The use consolidation services
    /// </summary>
    /// <value>The use consolidation services</value>
    [JsonPropertyName("use_consolidation_services")]
    public bool UseConsolidationServices { get; set; }

    /// <summary>
    /// The use order number on mail innovations labels
    /// </summary>
    /// <value>The use order number on mail innovations labels</value>
    [JsonPropertyName("use_order_number_on_mail_innovations_labels")]
    public bool UseOrderNumberOnMailInnovationsLabels { get; set; }

    /// <summary>
    /// mail innovations cost center
    /// </summary>
    /// <value>mail innovations cost center</value>
    [JsonPropertyName("mail_innovations_cost_center")]
    public string MailInnovationsCostCenter { get; set; }

    /// <summary>
    /// The use negotiated rates
    /// </summary>
    /// <value>The use negotiated rates</value>
    [JsonPropertyName("use_negotiated_rates")]
    public bool UseNegotiatedRates { get; set; }

    /// <summary>
    /// account postal code
    /// </summary>
    /// <value>account postal code</value>
    [JsonPropertyName("account_postal_code")]
    public string AccountPostalCode { get; set; }

    /// <summary>
    /// The invoice
    /// </summary>
    /// <value>The invoice</value>
    [JsonPropertyName("invoice")]
    public UpsInvoice Invoice { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UpdateUpsSettingsRequestBody {\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  IsPrimaryAccount: ").Append(IsPrimaryAccount).Append("\n");
        sb.Append("  PickupType: ").Append(PickupType).Append("\n");
        sb.Append("  UseCarbonNeutralShippingProgram: ").Append(UseCarbonNeutralShippingProgram).Append("\n");
        sb.Append("  UseGroundFreightPricing: ").Append(UseGroundFreightPricing).Append("\n");
        sb.Append("  UseConsolidationServices: ").Append(UseConsolidationServices).Append("\n");
        sb.Append("  UseOrderNumberOnMailInnovationsLabels: ").Append(UseOrderNumberOnMailInnovationsLabels).Append("\n");
        sb.Append("  MailInnovationsEndorsement: ").Append(MailInnovationsEndorsement).Append("\n");
        sb.Append("  MailInnovationsCostCenter: ").Append(MailInnovationsCostCenter).Append("\n");
        sb.Append("  UseNegotiatedRates: ").Append(UseNegotiatedRates).Append("\n");
        sb.Append("  AccountPostalCode: ").Append(AccountPostalCode).Append("\n");
        sb.Append("  Invoice: ").Append(Invoice).Append("\n");
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