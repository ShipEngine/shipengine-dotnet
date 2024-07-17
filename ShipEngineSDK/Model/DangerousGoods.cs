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
/// Dangerous goods attribute associated with the product 
/// </summary>
public partial class DangerousGoods
{

    /// <summary>
    /// Provider additonal description regarding the dangerous goods. This is used as a placed holder to provider additional context and varies by carrier
    /// </summary>
    /// <value>Provider additonal description regarding the dangerous goods. This is used as a placed holder to provider additional context and varies by carrier</value>
    [JsonPropertyName("additional_description"), JsonPropertyOrder(1)]
    public string? AdditionalDescription { get; set; }

    /// <summary>
    /// This model represents the amount of the dangerous goods.
    /// </summary>
    /// <value>This model represents the amount of the dangerous goods.</value>
    [JsonPropertyName("dangerous_amount"), JsonPropertyOrder(2)]
    public DangerousAmount? DangerousAmount { get; set; }

    /// <summary>
    /// UN number to identify the dangerous goods.
    /// </summary>
    /// <value>UN number to identify the dangerous goods.</value>
    [JsonPropertyName("id_number"), JsonPropertyOrder(3)]
    public string? IdNumber { get; set; }

    /// <summary>
    /// Gets or Sets PackagingGroup
    /// </summary>
    [JsonPropertyName("packaging_group"), JsonPropertyOrder(4)]
    public PackagingGroup? PackagingGroup { get; set; }

    /// <summary>
    /// The specific standardized packaging instructions from the relevant regulatory agency that have been applied to the parcel/container.
    /// </summary>
    /// <value>The specific standardized packaging instructions from the relevant regulatory agency that have been applied to the parcel/container.</value>
    [JsonPropertyName("packaging_instruction"), JsonPropertyOrder(5)]
    public string? PackagingInstruction { get; set; }

    /// <summary>
    /// Gets or Sets PackagingInstructionSection
    /// </summary>
    [JsonPropertyName("packaging_instruction_section"), JsonPropertyOrder(6)]
    public PackagingInstructionSection? PackagingInstructionSection { get; set; }

    /// <summary>
    /// The type of exterior packaging used to contain the dangerous good.
    /// </summary>
    /// <value>The type of exterior packaging used to contain the dangerous good.</value>
    [JsonPropertyName("packaging_type"), JsonPropertyOrder(7)]
    public string? PackagingType { get; set; }

    /// <summary>
    /// Dangerous goods product class based on regulation.
    /// </summary>
    /// <value>Dangerous goods product class based on regulation.</value>
    [JsonPropertyName("product_class"), JsonPropertyOrder(8)]
    public string? ProductClass { get; set; }

    /// <summary>
    /// A secondary of product class for substances presenting more than one particular hazard
    /// </summary>
    /// <value>A secondary of product class for substances presenting more than one particular hazard</value>
    [JsonPropertyName("product_class_subsidiary"), JsonPropertyOrder(9)]
    public string? ProductClassSubsidiary { get; set; }

    /// <summary>
    /// Quantity of dangerous goods.
    /// </summary>
    /// <value>Quantity of dangerous goods.</value>
    [JsonPropertyName("quantity"), JsonPropertyOrder(10)]
    public int? Quantity { get; set; }

    /// <summary>
    /// Indication if the substance is radioactive.
    /// </summary>
    /// <value>Indication if the substance is radioactive.</value>
    /// <example>
    /// false
    /// </example>
    [JsonPropertyName("radioactive"), JsonPropertyOrder(11)]
    public bool? Radioactive { get; set; }

    /// <summary>
    /// Name of the regulatory authority.
    /// </summary>
    /// <value>Name of the regulatory authority.</value>
    [JsonPropertyName("regulation_authority"), JsonPropertyOrder(12)]
    public string? RegulationAuthority { get; set; }

    /// <summary>
    /// Gets or Sets RegulationLevel
    /// </summary>
    [JsonPropertyName("regulation_level"), JsonPropertyOrder(13)]
    public RegulationLevel? RegulationLevel { get; set; }

    /// <summary>
    /// Indication if the substance needs to be reported to regulatory authority based on the quantity.
    /// </summary>
    /// <value>Indication if the substance needs to be reported to regulatory authority based on the quantity.</value>
    /// <example>
    /// false
    /// </example>
    [JsonPropertyName("reportable_quantity"), JsonPropertyOrder(14)]
    public bool? ReportableQuantity { get; set; }

    /// <summary>
    /// Trade description of the dangerous goods.
    /// </summary>
    /// <value>Trade description of the dangerous goods.</value>
    [JsonPropertyName("shipping_name"), JsonPropertyOrder(15)]
    public string? ShippingName { get; set; }

    /// <summary>
    /// Recognized Technical or chemical name of dangerous goods.
    /// </summary>
    /// <value>Recognized Technical or chemical name of dangerous goods.</value>
    [JsonPropertyName("technical_name"), JsonPropertyOrder(16)]
    public string? TechnicalName { get; set; }

    /// <summary>
    /// Transport category assign to dangerous goods for the transport purpose.
    /// </summary>
    /// <value>Transport category assign to dangerous goods for the transport purpose.</value>
    [JsonPropertyName("transport_category"), JsonPropertyOrder(17)]
    public string? TransportCategory { get; set; }

    /// <summary>
    /// Gets or Sets TransportMean
    /// </summary>
    [JsonPropertyName("transport_mean"), JsonPropertyOrder(18)]
    public TransportMean? TransportMean { get; set; }

    /// <summary>
    /// Defines which types of tunnels the shipment is allowed to go through
    /// </summary>
    /// <value>Defines which types of tunnels the shipment is allowed to go through</value>
    [JsonPropertyName("tunnel_code"), JsonPropertyOrder(19)]
    public string? TunnelCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DangerousGoods {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  AdditionalDescription: ").Append(AdditionalDescription).Append("\n");
        sb.Append("  DangerousAmount: ").Append(DangerousAmount).Append("\n");
        sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
        sb.Append("  PackagingGroup: ").Append(PackagingGroup).Append("\n");
        sb.Append("  PackagingInstruction: ").Append(PackagingInstruction).Append("\n");
        sb.Append("  PackagingInstructionSection: ").Append(PackagingInstructionSection).Append("\n");
        sb.Append("  PackagingType: ").Append(PackagingType).Append("\n");
        sb.Append("  ProductClass: ").Append(ProductClass).Append("\n");
        sb.Append("  ProductClassSubsidiary: ").Append(ProductClassSubsidiary).Append("\n");
        sb.Append("  Quantity: ").Append(Quantity).Append("\n");
        sb.Append("  Radioactive: ").Append(Radioactive).Append("\n");
        sb.Append("  RegulationAuthority: ").Append(RegulationAuthority).Append("\n");
        sb.Append("  RegulationLevel: ").Append(RegulationLevel).Append("\n");
        sb.Append("  ReportableQuantity: ").Append(ReportableQuantity).Append("\n");
        sb.Append("  ShippingName: ").Append(ShippingName).Append("\n");
        sb.Append("  TechnicalName: ").Append(TechnicalName).Append("\n");
        sb.Append("  TransportCategory: ").Append(TransportCategory).Append("\n");
        sb.Append("  TransportMean: ").Append(TransportMean).Append("\n");
        sb.Append("  TunnelCode: ").Append(TunnelCode).Append("\n");
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