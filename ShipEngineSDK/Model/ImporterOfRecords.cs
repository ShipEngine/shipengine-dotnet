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
/// importer of records address, anywhere in the world. 
/// </summary>
public partial class ImporterOfRecords
{

    /// <summary>
    /// The name of a contact person at this address. Either &#x60;name&#x60; or the &#x60;company_name&#x60; field should always be set. 
    /// </summary>
    /// <value>The name of a contact person at this address. Either &#x60;name&#x60; or the &#x60;company_name&#x60; field should always be set. </value>
    /// <example>
    /// John Doe
    /// </example>
    [JsonPropertyName("name")]
    [JsonRequired]
    public string Name { get; set; }

    /// <summary>
    /// The phone number of a contact person at this address.  The format of this phone number varies depending on the country. 
    /// </summary>
    /// <value>The phone number of a contact person at this address.  The format of this phone number varies depending on the country. </value>
    /// <example>
    /// +1 204-253-9411 ext. 123
    /// </example>
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Email for the address owner. 
    /// </summary>
    /// <value>Email for the address owner. </value>
    /// <example>
    /// example@example.com
    /// </example>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// If this is a business address, then the company name should be specified here. Either &#x60;name&#x60; or the &#x60;company_name&#x60; field should always be set. 
    /// </summary>
    /// <value>If this is a business address, then the company name should be specified here. Either &#x60;name&#x60; or the &#x60;company_name&#x60; field should always be set. </value>
    /// <example>
    /// The Home Depot
    /// </example>
    [JsonPropertyName("company_name")]
    public string CompanyName { get; set; }

    /// <summary>
    /// The first line of the street address.  For some addresses, this may be the only line.  Other addresses may require 2 or 3 lines. 
    /// </summary>
    /// <value>The first line of the street address.  For some addresses, this may be the only line.  Other addresses may require 2 or 3 lines. </value>
    /// <example>
    /// 1999 Bishop Grandin Blvd.
    /// </example>
    [JsonPropertyName("address_line1")]
    [JsonRequired]
    public string AddressLine1 { get; set; }

    /// <summary>
    /// The second line of the street address.  For some addresses, this line may not be needed. 
    /// </summary>
    /// <value>The second line of the street address.  For some addresses, this line may not be needed. </value>
    /// <example>
    /// Unit 408
    /// </example>
    [JsonPropertyName("address_line2")]
    public string AddressLine2 { get; set; }

    /// <summary>
    /// The third line of the street address.  For some addresses, this line may not be needed. 
    /// </summary>
    /// <value>The third line of the street address.  For some addresses, this line may not be needed. </value>
    /// <example>
    /// Building #7
    /// </example>
    [JsonPropertyName("address_line3")]
    public string AddressLine3 { get; set; }

    /// <summary>
    /// The name of the city or locality
    /// </summary>
    /// <value>The name of the city or locality</value>
    /// <example>
    /// Winnipeg
    /// </example>
    [JsonPropertyName("city_locality")]
    [JsonRequired]
    public string CityLocality { get; set; }

    /// <summary>
    /// The state or province.  For some countries (including the U.S.) only abbreviations are allowed.  Other countries allow the full name or abbreviation. 
    /// </summary>
    /// <value>The state or province.  For some countries (including the U.S.) only abbreviations are allowed.  Other countries allow the full name or abbreviation. </value>
    /// <example>
    /// Manitoba
    /// </example>
    [JsonPropertyName("state_province")]
    public string StateProvince { get; set; }

    /// <summary>
    /// postal code
    /// </summary>
    /// <value>postal code</value>
    /// <example>
    /// 78756-3717
    /// </example>
    [JsonPropertyName("postal_code")]
    [JsonRequired]
    public string PostalCode { get; set; }

    /// <summary>
    /// The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) 
    /// </summary>
    /// <value>The two-letter [ISO 3166-1 country code](https://en.wikipedia.org/wiki/ISO_3166-1) </value>
    /// <example>
    /// CA
    /// </example>
    [JsonPropertyName("country_code")]
    [JsonRequired]
    public string CountryCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ImporterOfRecords {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Phone: ").Append(Phone).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
        sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
        sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
        sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
        sb.Append("  CityLocality: ").Append(CityLocality).Append("\n");
        sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
        sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
        sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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