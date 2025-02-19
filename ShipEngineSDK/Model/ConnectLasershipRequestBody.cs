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
/// A Lasership account information request body
/// </summary>
public partial class ConnectLasershipRequestBody
{

    /// <summary>
    /// Address
    /// </summary>
    /// <value>Address</value>
    [JsonPropertyName("Address"), JsonPropertyOrder(1)]
    public required String Address { get; set; }

    /// <summary>
    /// City
    /// </summary>
    /// <value>City</value>
    [JsonPropertyName("City"), JsonPropertyOrder(2)]
    public required String City { get; set; }

    /// <summary>
    /// Customer Branch
    /// </summary>
    /// <value>Customer Branch</value>
    [JsonPropertyName("customer_branch"), JsonPropertyOrder(3)]
    public required string CustomerBranch { get; set; }

    /// <summary>
    /// Critical Entry Time (local time)
    /// </summary>
    /// <value>Critical Entry Time (local time)</value>
    [JsonPropertyName("lasership_critical_entry_time"), JsonPropertyOrder(4)]
    public required String LasershipCriticalEntryTime { get; set; }

    /// <summary>
    /// Critical Pull Time (local time)
    /// </summary>
    /// <value>Critical Pull Time (local time)</value>
    [JsonPropertyName("lasership_critical_pull_time"), JsonPropertyOrder(5)]
    public required String LasershipCriticalPullTime { get; set; }

    /// <summary>
    /// Nickname
    /// </summary>
    /// <value>Nickname</value>
    [JsonPropertyName("nickname"), JsonPropertyOrder(6)]
    public required string Nickname { get; set; }

    /// <summary>
    /// PostalCode
    /// </summary>
    /// <value>PostalCode</value>
    [JsonPropertyName("PostalCode"), JsonPropertyOrder(7)]
    public required String PostalCode { get; set; }

    /// <summary>
    /// State
    /// </summary>
    /// <value>State</value>
    [JsonPropertyName("State"), JsonPropertyOrder(8)]
    public required String State { get; set; }

    /// <summary>
    /// Web Service ID (WSID)
    /// </summary>
    /// <value>Web Service ID (WSID)</value>
    [JsonPropertyName("web_services_id"), JsonPropertyOrder(9)]
    public required string WebServicesId { get; set; }

    /// <summary>
    /// Web Service Key (WSKey)
    /// </summary>
    /// <value>Web Service Key (WSKey)</value>
    [JsonPropertyName("web_services_key"), JsonPropertyOrder(10)]
    public required string WebServicesKey { get; set; }

    /// <summary>
    /// Address2
    /// </summary>
    /// <value>Address2</value>
    [JsonPropertyName("Address2"), JsonPropertyOrder(11)]
    public String? Address2 { get; set; }

    /// <summary>
    /// Set this to true if your shipments will always contain Alcohol
    /// </summary>
    /// <value>Set this to true if your shipments will always contain Alcohol</value>
    [JsonPropertyName("AttrAlcohol"), JsonPropertyOrder(12)]
    public Boolean? AttrAlcohol { get; set; }

    /// <summary>
    /// Set this to true if your shipments will always contain Controlled Substances
    /// </summary>
    /// <value>Set this to true if your shipments will always contain Controlled Substances</value>
    [JsonPropertyName("AttrControlledSubstance"), JsonPropertyOrder(13)]
    public Boolean? AttrControlledSubstance { get; set; }

    /// <summary>
    /// Set this to true if your shipments will always contain DryIce
    /// </summary>
    /// <value>Set this to true if your shipments will always contain DryIce</value>
    [JsonPropertyName("AttrDryIce"), JsonPropertyOrder(14)]
    public Boolean? AttrDryIce { get; set; }

    /// <summary>
    /// Set this to true if your shipments will always contain Explosives
    /// </summary>
    /// <value>Set this to true if your shipments will always contain Explosives</value>
    [JsonPropertyName("AttrExplosive"), JsonPropertyOrder(15)]
    public Boolean? AttrExplosive { get; set; }

    /// <summary>
    /// Set this to true if your shipments will always contain Hazmat
    /// </summary>
    /// <value>Set this to true if your shipments will always contain Hazmat</value>
    [JsonPropertyName("AttrHazmat"), JsonPropertyOrder(16)]
    public Boolean? AttrHazmat { get; set; }

    /// <summary>
    /// Set this to true if your shipments will always use \&quot;No Return To Sender\&quot;
    /// </summary>
    /// <value>Set this to true if your shipments will always use \&quot;No Return To Sender\&quot;</value>
    [JsonPropertyName("AttrNoRTS"), JsonPropertyOrder(17)]
    public Boolean? AttrNoRTS { get; set; }

    /// <summary>
    /// Set this to true if your shipments will always be Perishable
    /// </summary>
    /// <value>Set this to true if your shipments will always be Perishable</value>
    [JsonPropertyName("AttrPerishable"), JsonPropertyOrder(18)]
    public Boolean? AttrPerishable { get; set; }

    /// <summary>
    /// Set this to true if your shipments will always require Refrigeration
    /// </summary>
    /// <value>Set this to true if your shipments will always require Refrigeration</value>
    [JsonPropertyName("AttrRefrigerated"), JsonPropertyOrder(19)]
    public Boolean? AttrRefrigerated { get; set; }

    /// <summary>
    /// Set this to true if your shipments will always require Two Persons
    /// </summary>
    /// <value>Set this to true if your shipments will always require Two Persons</value>
    [JsonPropertyName("AttrTwoPersons"), JsonPropertyOrder(20)]
    public Boolean? AttrTwoPersons { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    /// <value>Country</value>
    [JsonPropertyName("country"), JsonPropertyOrder(21)]
    public String? Country { get; set; }

    /// <summary>
    /// Declare piece attributes separately for every shipment, overrides individual attribute below.
    /// </summary>
    /// <value>Declare piece attributes separately for every shipment, overrides individual attribute below.</value>
    [JsonPropertyName("declare_piece_attributes_separately_for_every_shipment"), JsonPropertyOrder(22)]
    public Boolean? DeclarePieceAttributesSeparatelyForEveryShipment { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    /// <value>Email</value>
    [JsonPropertyName("Email"), JsonPropertyOrder(23)]
    public String? Email { get; set; }

    /// <summary>
    /// Facility Code
    /// </summary>
    /// <value>Facility Code</value>
    [JsonPropertyName("facility_code"), JsonPropertyOrder(24)]
    public String? FacilityCode { get; set; }

    /// <summary>
    /// Instructions
    /// </summary>
    /// <value>Instructions</value>
    [JsonPropertyName("instructions"), JsonPropertyOrder(25)]
    public String? Instructions { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    /// <value>Phone</value>
    [JsonPropertyName("Phone"), JsonPropertyOrder(26)]
    public String? Phone { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConnectLasershipRequestBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  City: ").Append(City).Append("\n");
        sb.Append("  CustomerBranch: ").Append(CustomerBranch).Append("\n");
        sb.Append("  LasershipCriticalEntryTime: ").Append(LasershipCriticalEntryTime).Append("\n");
        sb.Append("  LasershipCriticalPullTime: ").Append(LasershipCriticalPullTime).Append("\n");
        sb.Append("  Nickname: ").Append(Nickname).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  WebServicesId: ").Append(WebServicesId).Append("\n");
        sb.Append("  WebServicesKey: ").Append(WebServicesKey).Append("\n");
        sb.Append("  Address2: ").Append(Address2).Append("\n");
        sb.Append("  AttrAlcohol: ").Append(AttrAlcohol).Append("\n");
        sb.Append("  AttrControlledSubstance: ").Append(AttrControlledSubstance).Append("\n");
        sb.Append("  AttrDryIce: ").Append(AttrDryIce).Append("\n");
        sb.Append("  AttrExplosive: ").Append(AttrExplosive).Append("\n");
        sb.Append("  AttrHazmat: ").Append(AttrHazmat).Append("\n");
        sb.Append("  AttrNoRTS: ").Append(AttrNoRTS).Append("\n");
        sb.Append("  AttrPerishable: ").Append(AttrPerishable).Append("\n");
        sb.Append("  AttrRefrigerated: ").Append(AttrRefrigerated).Append("\n");
        sb.Append("  AttrTwoPersons: ").Append(AttrTwoPersons).Append("\n");
        sb.Append("  Country: ").Append(Country).Append("\n");
        sb.Append("  DeclarePieceAttributesSeparatelyForEveryShipment: ").Append(DeclarePieceAttributesSeparatelyForEveryShipment).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  FacilityCode: ").Append(FacilityCode).Append("\n");
        sb.Append("  Instructions: ").Append(Instructions).Append("\n");
        sb.Append("  Phone: ").Append(Phone).Append("\n");
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