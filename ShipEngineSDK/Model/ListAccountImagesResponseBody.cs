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
using System.Linq;
using System.IO;
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
//[DataContract(Name = "list_account_images_response_body")]
public partial class ListAccountImagesResponseBody
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
        sb.Append("class ListAccountImagesResponseBody {\n");
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

