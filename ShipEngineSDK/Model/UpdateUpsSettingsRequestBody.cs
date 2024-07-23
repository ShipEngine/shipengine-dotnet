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
/// An update UPS settings request body
/// </summary>
public partial class UpdateUpsSettingsRequestBody
{

    /// <summary>
    /// account postal code
    /// </summary>
    /// <value>account postal code</value>
    [JsonPropertyName("account_postal_code"), JsonPropertyOrder(1)]
    public string? AccountPostalCode { get; set; }

    /// <summary>
    /// The invoice
    /// </summary>
    /// <value>The invoice</value>
    [JsonPropertyName("invoice"), JsonPropertyOrder(2)]
    public UpsInvoice? Invoice { get; set; }

    /// <summary>
    /// Indicates if this is the primary UPS account
    /// </summary>
    /// <value>Indicates if this is the primary UPS account</value>
    [JsonPropertyName("is_primary_account"), JsonPropertyOrder(3)]
    public bool? IsPrimaryAccount { get; set; }

    /// <summary>
    /// mail innovations cost center
    /// </summary>
    /// <value>mail innovations cost center</value>
    [JsonPropertyName("mail_innovations_cost_center"), JsonPropertyOrder(4)]
    public string? MailInnovationsCostCenter { get; set; }

    /// <summary>
    /// Gets or Sets MailInnovationsEndorsement
    /// </summary>
    [JsonPropertyName("mail_innovations_endorsement"), JsonPropertyOrder(5)]
    public AncillaryServiceEndorsement? MailInnovationsEndorsement { get; set; }

    /// <summary>
    /// nickname
    /// </summary>
    /// <value>nickname</value>
    [JsonPropertyName("nickname"), JsonPropertyOrder(6)]
    public string? Nickname { get; set; }

    /// <summary>
    /// Gets or Sets PickupType
    /// </summary>
    [JsonPropertyName("pickup_type"), JsonPropertyOrder(7)]
    public UpsPickupType? PickupType { get; set; }

    /// <summary>
    /// The use carbon neutral shipping program
    /// </summary>
    /// <value>The use carbon neutral shipping program</value>
    [JsonPropertyName("use_carbon_neutral_shipping_program"), JsonPropertyOrder(8)]
    public bool? UseCarbonNeutralShippingProgram { get; set; }

    /// <summary>
    /// The use consolidation services
    /// </summary>
    /// <value>The use consolidation services</value>
    [JsonPropertyName("use_consolidation_services"), JsonPropertyOrder(9)]
    public bool? UseConsolidationServices { get; set; }

    /// <summary>
    /// The use ground freight pricing
    /// </summary>
    /// <value>The use ground freight pricing</value>
    [JsonPropertyName("use_ground_freight_pricing"), JsonPropertyOrder(10)]
    public bool? UseGroundFreightPricing { get; set; }

    /// <summary>
    /// The use negotiated rates
    /// </summary>
    /// <value>The use negotiated rates</value>
    [JsonPropertyName("use_negotiated_rates"), JsonPropertyOrder(11)]
    public bool? UseNegotiatedRates { get; set; }

    /// <summary>
    /// The use order number on mail innovations labels
    /// </summary>
    /// <value>The use order number on mail innovations labels</value>
    [JsonPropertyName("use_order_number_on_mail_innovations_labels"), JsonPropertyOrder(12)]
    public bool? UseOrderNumberOnMailInnovationsLabels { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UpdateUpsSettingsRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AccountPostalCode: ").Append(AccountPostalCode).Append("\n");
        sb.Append("  Invoice: ").Append(Invoice).Append("\n");
        sb.Append("  IsPrimaryAccount: ").Append(IsPrimaryAccount).Append("\n");
        sb.Append("  MailInnovationsCostCenter: ").Append(MailInnovationsCostCenter).Append("\n");
        sb.Append("  MailInnovationsEndorsement: ").Append(MailInnovationsEndorsement).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  PickupType: ").Append(PickupType).Append("\n");
        sb.Append("  UseCarbonNeutralShippingProgram: ").Append(UseCarbonNeutralShippingProgram).Append("\n");
        sb.Append("  UseConsolidationServices: ").Append(UseConsolidationServices).Append("\n");
        sb.Append("  UseGroundFreightPricing: ").Append(UseGroundFreightPricing).Append("\n");
        sb.Append("  UseNegotiatedRates: ").Append(UseNegotiatedRates).Append("\n");
        sb.Append("  UseOrderNumberOnMailInnovationsLabels: ").Append(UseOrderNumberOnMailInnovationsLabels).Append("\n");
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