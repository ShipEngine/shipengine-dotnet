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
/// A shipment item
/// </summary>
//[DataContract(Name = "shipment_item")]
public partial class ShipmentItem
{

    /// <summary>
    /// Gets or Sets OrderSourceCode  CLOVUS
    /// </summary>
    [JsonPropertyName("order_source_code")]
    public OrderSourceName? OrderSourceCode { get; set; }
    /// <summary>
    /// item name
    /// </summary>
    /// <value>item name</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// sales order id
    /// </summary>
    /// <value>sales order id</value>
    [JsonPropertyName("sales_order_id")]
    public string SalesOrderId { get; set; }

    /// <summary>
    /// sales order item id
    /// </summary>
    /// <value>sales order item id</value>
    [JsonPropertyName("sales_order_item_id")]
    public string SalesOrderItemId { get; set; }

    /// <summary>
    /// The quantity of this item included in the shipment
    /// </summary>
    /// <value>The quantity of this item included in the shipment</value>
    [JsonPropertyName("quantity")]
    public int Quantity { get; set; }

    /// <summary>
    /// Item Stock Keeping Unit
    /// </summary>
    /// <value>Item Stock Keeping Unit</value>
    [JsonPropertyName("sku")]
    public string Sku { get; set; }

    /// <summary>
    /// external order id
    /// </summary>
    /// <value>external order id</value>
    [JsonPropertyName("external_order_id")]
    public string ExternalOrderId { get; set; }

    /// <summary>
    /// external order item id
    /// </summary>
    /// <value>external order item id</value>
    [JsonPropertyName("external_order_item_id")]
    public string ExternalOrderItemId { get; set; }

    /// <summary>
    /// Amazon Standard Identification Number
    /// </summary>
    /// <value>Amazon Standard Identification Number</value>
    /// <example>
    /// B00005N5PF
    /// </example>
    [JsonPropertyName("asin")]
    public string Asin { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ShipmentItem {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SalesOrderId: ").Append(SalesOrderId).Append("\n");
        sb.Append("  SalesOrderItemId: ").Append(SalesOrderItemId).Append("\n");
        sb.Append("  Quantity: ").Append(Quantity).Append("\n");
        sb.Append("  Sku: ").Append(Sku).Append("\n");
        sb.Append("  ExternalOrderId: ").Append(ExternalOrderId).Append("\n");
        sb.Append("  ExternalOrderItemId: ").Append(ExternalOrderItemId).Append("\n");
        sb.Append("  Asin: ").Append(Asin).Append("\n");
        sb.Append("  OrderSourceCode: ").Append(OrderSourceCode).Append("\n");
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