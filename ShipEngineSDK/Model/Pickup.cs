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
/// The information necessary to schedule a package pickup 
/// </summary>
//[DataContract(Name = "pickup")]
public partial class Pickup
{

    /// <summary>
    /// Pickup Resource ID
    /// </summary>
    /// <value>Pickup Resource ID</value>
    /// <example>
    /// pik_3YcKU5zdtJuCqoeNwyqqbW
    /// </example>
    [JsonPropertyName("pickup_id")]
    public string PickupId { get; private set; }

    /// <summary>
    /// Label IDs that will be included in the pickup request
    /// </summary>
    /// <value>Label IDs that will be included in the pickup request</value>
    [JsonPropertyName("label_ids")]
    public List<string> LabelIds { get; set; }

    /// <summary>
    /// The date and time that the pickup was created in ShipEngine.
    /// </summary>
    /// <value>The date and time that the pickup was created in ShipEngine.</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; private set; }

    /// <summary>
    /// The date and time that the pickup was cancelled in ShipEngine.
    /// </summary>
    /// <value>The date and time that the pickup was cancelled in ShipEngine.</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("cancelled_at")]
    public DateTime CancelledAt { get; private set; }

    /// <summary>
    /// The carrier_id associated with the pickup
    /// </summary>
    /// <value>The carrier_id associated with the pickup</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id")]
    public string CarrierId { get; private set; }

    /// <summary>
    /// The carrier confirmation number for the scheduled pickup.
    /// </summary>
    /// <value>The carrier confirmation number for the scheduled pickup.</value>
    /// <example>
    /// 292513CL4A3
    /// </example>
    [JsonPropertyName("confirmation_number")]
    public string ConfirmationNumber { get; private set; }

    /// <summary>
    /// The warehouse_id associated with the pickup
    /// </summary>
    /// <value>The warehouse_id associated with the pickup</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("warehouse_id")]
    public string WarehouseId { get; private set; }

    /// <summary>
    /// Gets or Sets PickupAddress
    /// </summary>
    [JsonPropertyName("pickup_address")]
    public Address PickupAddress { get; private set; }

    /// <summary>
    /// Gets or Sets ContactDetails
    /// </summary>
    [JsonPropertyName("contact_details")]
    public ContactDetails ContactDetails { get; set; }

    /// <summary>
    /// Used by some carriers to give special instructions for a package pickup
    /// </summary>
    /// <value>Used by some carriers to give special instructions for a package pickup</value>
    [JsonPropertyName("pickup_notes")]
    public string PickupNotes { get; set; }

    /// <summary>
    /// Gets or Sets PickupWindow
    /// </summary>
    [JsonPropertyName("pickup_window")]
    public PickupWindow PickupWindow { get; set; }

    /// <summary>
    /// An array of available pickup windows. Carriers can return multiple times that they will pickup packages. 
    /// </summary>
    /// <value>An array of available pickup windows. Carriers can return multiple times that they will pickup packages. </value>
    [JsonPropertyName("pickup_windows")]
    public List<PickupWindows> PickupWindows { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class Pickup {\n");
        sb.Append("  PickupId: ").Append(PickupId).Append("\n");
        sb.Append("  LabelIds: ").Append(LabelIds).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  CancelledAt: ").Append(CancelledAt).Append("\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  ConfirmationNumber: ").Append(ConfirmationNumber).Append("\n");
        sb.Append("  WarehouseId: ").Append(WarehouseId).Append("\n");
        sb.Append("  PickupAddress: ").Append(PickupAddress).Append("\n");
        sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
        sb.Append("  PickupNotes: ").Append(PickupNotes).Append("\n");
        sb.Append("  PickupWindow: ").Append(PickupWindow).Append("\n");
        sb.Append("  PickupWindows: ").Append(PickupWindows).Append("\n");
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