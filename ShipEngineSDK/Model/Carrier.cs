/*
 * ShipEngine API
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
/// A carrier object that represents a provider such as UPS, USPS, DHL, etc that has been tied to the current account. 
/// </summary>
public partial class Carrier
{

    /// <summary>
    /// The account number that the carrier is connected to.
    /// </summary>
    /// <value>The account number that the carrier is connected to.</value>
    /// <example>
    /// account_570827
    /// </example>
    [JsonPropertyName("account_number"), JsonInclude]
    public string? AccountNumber { get; private set; }

    /// <summary>
    /// Current available balance
    /// </summary>
    /// <value>Current available balance</value>
    /// <example>
    /// 3799.52
    /// </example>
    [JsonPropertyName("balance"), JsonInclude]
    public double? Balance { get; private set; }

    /// <summary>
    /// The [shipping carrier](https://www.shipengine.com/docs/carriers/setup/) who will ship the package, such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. 
    /// </summary>
    /// <value>The [shipping carrier](https://www.shipengine.com/docs/carriers/setup/) who will ship the package, such as &#x60;fedex&#x60;, &#x60;dhl_express&#x60;, &#x60;stamps_com&#x60;, etc. </value>
    /// <example>
    /// dhl_express
    /// </example>
    [JsonPropertyName("carrier_code"), JsonInclude]
    public string? CarrierCode { get; private set; }

    /// <summary>
    /// A string that uniquely identifies the carrier.
    /// </summary>
    /// <value>A string that uniquely identifies the carrier.</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("carrier_id"), JsonInclude]
    public string? CarrierId { get; private set; }

    /// <summary>
    /// The carrier is disabled by the current ShipEngine account&#39;s billing plan.
    /// </summary>
    /// <value>The carrier is disabled by the current ShipEngine account&#39;s billing plan.</value>
    [JsonPropertyName("disabled_by_billing_plan"), JsonInclude]
    public bool? DisabledByBillingPlan { get; private set; }

    /// <summary>
    /// Screen readable name
    /// </summary>
    /// <value>Screen readable name</value>
    /// <example>
    /// Stamps.com
    /// </example>
    [JsonPropertyName("friendly_name"), JsonInclude]
    public string? FriendlyName { get; private set; }

    /// <summary>
    /// Carrier supports multiple packages per shipment
    /// </summary>
    /// <value>Carrier supports multiple packages per shipment</value>
    [JsonPropertyName("has_multi_package_supporting_services"), JsonInclude]
    public bool? HasMultiPackageSupportingServices { get; private set; }

    /// <summary>
    /// Nickname given to the account when initially setting up the carrier.
    /// </summary>
    /// <value>Nickname given to the account when initially setting up the carrier.</value>
    /// <example>
    /// ShipEngine Account - Stamps.com
    /// </example>
    [JsonPropertyName("nickname"), JsonInclude]
    public string? Nickname { get; private set; }

    /// <summary>
    /// A list of options that are available to that carrier
    /// </summary>
    /// <value>A list of options that are available to that carrier</value>
    [JsonPropertyName("options"), JsonInclude]
    public List<CarrierAdvancedOption>? Options { get; private set; }

    /// <summary>
    /// A list of package types that are supported by the carrier
    /// </summary>
    /// <value>A list of package types that are supported by the carrier</value>
    [JsonPropertyName("packages"), JsonInclude]
    public List<PackageType>? Packages { get; private set; }

    /// <summary>
    /// Is this the primary carrier that is used by default when no carrier is specified in label/shipment creation
    /// </summary>
    /// <value>Is this the primary carrier that is used by default when no carrier is specified in label/shipment creation</value>
    [JsonPropertyName("primary"), JsonInclude]
    public bool? Primary { get; private set; }

    /// <summary>
    /// Indicates whether the carrier requires funding to use its services
    /// </summary>
    /// <value>Indicates whether the carrier requires funding to use its services</value>
    [JsonPropertyName("requires_funded_amount"), JsonInclude]
    public bool? RequiresFundedAmount { get; private set; }

    /// <summary>
    /// A list of services that are offered by the carrier
    /// </summary>
    /// <value>A list of services that are offered by the carrier</value>
    [JsonPropertyName("services"), JsonInclude]
    public List<Service>? Services { get; private set; }

    /// <summary>
    /// The carrier supports adding custom label messages to an order.
    /// </summary>
    /// <value>The carrier supports adding custom label messages to an order.</value>
    [JsonPropertyName("supports_label_messages"), JsonInclude]
    public bool? SupportsLabelMessages { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Carrier {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
        sb.Append("  Balance: ").Append(Balance).Append("\n");
        sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
        sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
        sb.Append("  DisabledByBillingPlan: ").Append(DisabledByBillingPlan).Append("\n");
        sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
        sb.Append("  HasMultiPackageSupportingServices: ").Append(HasMultiPackageSupportingServices).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  Options: ").Append(Options).Append("\n");
        sb.Append("  Packages: ").Append(Packages).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
        sb.Append("  RequiresFundedAmount: ").Append(RequiresFundedAmount).Append("\n");
        sb.Append("  Services: ").Append(Services).Append("\n");
        sb.Append("  SupportsLabelMessages: ").Append(SupportsLabelMessages).Append("\n");
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