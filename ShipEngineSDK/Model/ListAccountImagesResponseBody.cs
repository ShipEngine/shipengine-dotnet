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
/// A list account images response body
/// </summary>
public partial class ListAccountImagesResponseBody
{

    /// <summary>
    /// Type of data of the elements in the list
    /// </summary>
    public class ListAccountImagesResponseBodyItem
    {
        /// <summary>
        /// A string that uniquely identifies the image. This ID is generated by ShipEngine when the image is uploaded. 
        /// </summary>
        /// <value>A string that uniquely identifies the image. This ID is generated by ShipEngine when the image is uploaded. </value>
        /// <example>
        /// img_DtBXupDBxREpHnwEXhTfgK
        /// </example>
        [JsonPropertyName("label_image_id"), JsonInclude]
        public string? LabelImageId { get; set; }

        /// <summary>
        /// A human readable name for the image. 
        /// </summary>
        /// <value>A human readable name for the image. </value>
        /// <example>
        /// My logo
        /// </example>
        [JsonPropertyName("name"), JsonPropertyOrder(2)]
        public string? Name { get; set; }

        /// <summary>
        /// Indicates whether this image is set as default. 
        /// </summary>
        /// <value>Indicates whether this image is set as default. </value>
        /// <example>
        /// false
        /// </example>
        [JsonPropertyName("is_default"), JsonPropertyOrder(3)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The file type of the image.  
        /// </summary>
        /// <value>The file type of the image.  </value>
        [JsonPropertyName("image_content_type"), JsonPropertyOrder(4)]
        public string? ImageContentType { get; set; }

        /// <summary>
        /// A base64 encoded string representation of the image. 
        /// </summary>
        /// <value>A base64 encoded string representation of the image. </value>
        /// <example>
        /// iVBORw0KGgoAAAANSUhEUgAAABkAAAAZCAYAAADE6YVjAAAAAXNSR0IArs4c6QAAAiVJREFUSEu91j3IeVEcB/CvSTIoBrFSikEZMdjsjExeUspgUEp5SUpeshrIgEFJJmWwMZHJQGHDhJSXTPfpnH/8ebzd56HnN93u7ZzP/f1+55x7Ob1ejxEKheByufh0HI9HrFYrcKbTKUMu5HI5BALBx5zNZoPxeAySAGc2mzF8Pp/e+BR0Ash8u93uHyKVSnH54J2Mvs8zn8//I6RO70L3xt8g70CPXvAu8hvoWQUeIj+BXpX4KcIGegWQOV4izyA2AGvkHsQW+BFyCUkkEiwWC9Ybl1W5Ls8ZMoAABCIbmE3cINFoFMFgEEajEeVyGSKRCJ1OB3q9ns5nMpmQTCaxXq9/l8loNEKj0YDX66UACYvFQq9brRYcDgdUKhU9RD/SEwLm83lEIhGUSiX0+33E4/GrU5otRMs1mUyYbDYLu90OhUJBMzhlZbPZ4Pf7odFo4HQ6b1rABqJIvV5nttstLc0pSIn2+z0tTy6XQ6FQoI/a7TZ0Ot0V9gqiiMFgYKrVKm0yieVyCZ/PB6vVSpF0Ok2zJHEqIY/HYw1RxOfzMYlE4jwoEAhAJpPBbDZf9eBwOCCVSsHtdp9f6FJ6egorlUqmVqvRfjSbTXS7XXg8nptP8Svk0RF01ROtVguSUTgchlgsPpeOZBaLxTAcDlEsFpHJZPC9XM8yoshgMGBCoRBdQWTCU7hcLjohWb5kM6rValQqlfMKfLbbb77xf/K38hf/XV9ilOpnLqvnogAAAABJRU5ErkJggg&#x3D;&#x3D;
        /// </example>
        [JsonPropertyName("image_data"), JsonPropertyOrder(5)]
        public string? ImageData { get; set; }

        /// <summary>
        /// The date and time that the image was created in ShipEngine.
        /// </summary>
        /// <value>The date and time that the image was created in ShipEngine.</value>
        /// <example>
        /// 2018-09-23T15:00Z
        /// </example>
        [JsonPropertyName("created_at"), JsonInclude]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The date and time that the image was modified in ShipEngine.
        /// </summary>
        /// <value>The date and time that the image was modified in ShipEngine.</value>
        /// <example>
        /// 2018-09-23T15:00Z
        /// </example>
        [JsonPropertyName("modified_at"), JsonInclude]
        public DateTimeOffset? ModifiedAt { get; set; }

    }
    /// <summary>
    /// Image List
    /// </summary>
    /// <value>Image List</value>
    /// <remarks>
    /// This should not be used for input as it will be ignored on serialization.
    /// </remarks>
    [JsonPropertyName("images"), JsonInclude]
    public List<ListAccountImagesResponseBodyItem>? Images { get; set; }

    /// <summary>
    /// Gets or Sets Links
    /// </summary>
    [JsonPropertyName("links"), JsonPropertyOrder(2)]
    public required PaginationLink Links { get; set; }

    /// <summary>
    /// The current page number of results.  For example, if there are 80 results, and the page size is 25, then &#x60;page&#x60; could be 1, 2, 3, or 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.
    /// </summary>
    /// <value>The current page number of results.  For example, if there are 80 results, and the page size is 25, then &#x60;page&#x60; could be 1, 2, 3, or 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.</value>
    /// <example>
    /// 1
    /// </example>
    [JsonPropertyName("page"), JsonPropertyOrder(3)]
    public required int Page { get; set; }

    /// <summary>
    /// The total number of pages of results.  For example, if there are 80 results, and the page size is 25, then &#x60;pages&#x60; would be 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.  If there are no results, then &#x60;pages&#x60; will be zero.
    /// </summary>
    /// <value>The total number of pages of results.  For example, if there are 80 results, and the page size is 25, then &#x60;pages&#x60; would be 4.  The first three pages would contain 25 items each, and the fourth page would contain the five remaining items.  If there are no results, then &#x60;pages&#x60; will be zero.</value>
    /// <example>
    /// 4
    /// </example>
    [JsonPropertyName("pages"), JsonPropertyOrder(4)]
    public required int Pages { get; set; }

    /// <summary>
    /// The total number of items across all pages of results
    /// </summary>
    /// <value>The total number of items across all pages of results</value>
    /// <example>
    /// 2750
    /// </example>
    [JsonPropertyName("total"), JsonPropertyOrder(5)]
    public required int Total { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ListAccountImagesResponseBody {\n");
#pragma warning disable CS0612 // Type or member is obsolete
        sb.Append("  Images: ").Append(Images).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("  Page: ").Append(Page).Append("\n");
        sb.Append("  Pages: ").Append(Pages).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
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