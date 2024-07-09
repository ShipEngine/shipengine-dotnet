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
/// ListAccountSettingsImagesResponseBody
/// </summary>
//[DataContract(Name = "list_account_settings_images_response_body")]
public partial class ListAccountSettingsImagesResponseBody
{

    /// <summary>
    /// Image List
    /// </summary>
    /// <value>Image List</value>
    [JsonPropertyName("images")]
    [JsonRequired]
    public List<Object> Images { get; set; }

    /// <summary>
    /// The total number of items across all pages of results
    /// </summary>
    /// <value>The total number of items across all pages of results</value>
    /// <example>
    /// 2750
    /// </example>
    [JsonPropertyName("total")]
    [JsonRequired]
    public int Total { get; set; }

    /// <summary>
    /// The current page number of results.  For example, if there are 80 results, and the page size is 25, then &#x60;page&#x60; could be 1, 2, 3, or 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.
    /// </summary>
    /// <value>The current page number of results.  For example, if there are 80 results, and the page size is 25, then &#x60;page&#x60; could be 1, 2, 3, or 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("page")]
    [JsonRequired]
    public int Page { get; set; }

    /// <summary>
    /// The total number of pages of results.  For example, if there are 80 results, and the page size is 25, then &#x60;pages&#x60; would be 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.  If there are no results, then &#x60;pages&#x60; will be zero.
    /// </summary>
    /// <value>The total number of pages of results.  For example, if there are 80 results, and the page size is 25, then &#x60;pages&#x60; would be 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.  If there are no results, then &#x60;pages&#x60; will be zero.</value>
    /// <example>
    /// 4
    /// </example>
    [JsonPropertyName("pages")]
    [JsonRequired]
    public int Pages { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [JsonPropertyName("links")]
    [JsonRequired]
    public PaginationLink Links { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class ListAccountSettingsImagesResponseBody {\n");
        sb.Append("  Images: ").Append(Images).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  Pages: ").Append(Pages).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
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