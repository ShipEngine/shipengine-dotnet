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
/// UPS invoice
/// </summary>
//[DataContract(Name = "ups_invoice")]
public partial class UpsInvoice
{

    /// <summary>
    /// invoice date
    /// </summary>
    /// <value>invoice date</value>
    [JsonPropertyName("invoice_date")]
    public DateTime InvoiceDate { get; set; }

    /// <summary>
    /// invoice number
    /// </summary>
    /// <value>invoice number</value>
    [JsonPropertyName("invoice_number")]
    public string InvoiceNumber { get; set; }

    /// <summary>
    /// A string that uniquely identifies the control
    /// </summary>
    /// <value>A string that uniquely identifies the control</value>
    /// <example>
    /// se-28529731
    /// </example>
    [JsonPropertyName("control_id")]
    public string ControlId { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceAmount
    /// </summary>
    [JsonPropertyName("invoice_amount")]
    public double InvoiceAmount { get; set; }

    /// <summary>
    /// Gets or Sets InvoiceCurrencyCode
    /// </summary>
    [JsonPropertyName("invoice_currency_code")]
    public string InvoiceCurrencyCode { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class UpsInvoice {\n");
        sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
        sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
        sb.Append("  ControlId: ").Append(ControlId).Append("\n");
        sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append("\n");
        sb.Append("  InvoiceCurrencyCode: ").Append(InvoiceCurrencyCode).Append("\n");
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