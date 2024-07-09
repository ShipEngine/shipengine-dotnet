/*
 * ShipEngine API
 *
 * ShipEngine's easy-to-use REST API lets you manage all of your shipping needs without worrying about the complexities of different carrier APIs and protocols. We handle all the heavy lifting so you can focus on providing a first-class shipping experience for your customers at the best possible prices.  Each of ShipEngine's features can be used by itself or in conjunction with each other to build powerful shipping functionality into your application or service.  ## Getting Started If you're new to REST APIs then be sure to read our [introduction to REST](https://www.shipengine.com/docs/rest/) to understand the basics.  Learn how to [authenticate yourself to ShipEngine](https://www.shipengine.com/docs/auth/), and then use our [sandbox environment](https://www.shipengine.com/docs/sandbox/) to kick the tires and get familiar with our API. If you run into any problems, then be sure to check the [error handling guide](https://www.shipengine.com/docs/errors/) for tips.  Here are some step-by-step **tutorials** to get you started:    - [Learn how to create your first shipping label](https://www.shipengine.com/docs/labels/create-a-label/)   - [Calculate shipping costs and compare rates across carriers](https://www.shipengine.com/docs/rates/)   - [Track packages on-demand or in real time](https://www.shipengine.com/docs/tracking/)   - [Validate mailing addresses anywhere on Earth](https://www.shipengine.com/docs/addresses/validation/)   ## Shipping Labels for Every Major Carrier ShipEngine makes it easy to [create shipping labels for any carrier](https://www.shipengine.com/docs/labels/create-a-label/) and [download them](https://www.shipengine.com/docs/labels/downloading/) in a [variety of file formats](https://www.shipengine.com/docs/labels/formats/). You can even customize labels with your own [messages](https://www.shipengine.com/docs/labels/messages/) and [images](https://www.shipengine.com/docs/labels/branding/).   ## Real-Time Package Tracking With ShipEngine you can [get the current status of a package](https://www.shipengine.com/docs/tracking/) or [subscribe to real-time tracking updates](https://www.shipengine.com/docs/tracking/webhooks/) via webhooks. You can also create [custimized tracking pages](https://www.shipengine.com/docs/tracking/branded-tracking-page/) with your own branding so your customers will always know where their package is.   ## Compare Shipping Costs Across Carriers Make sure you ship as cost-effectively as possible by [comparing rates across carriers](https://www.shipengine.com/docs/rates/get-shipment-rates/) using the ShipEngine Rates API. Or if you don't know the full shipment details yet, then you can [get rate estimates](https://www.shipengine.com/docs/rates/estimate/) with limited address info.   ## Worldwide Address Validation ShipEngine supports [address validation](https://www.shipengine.com/docs/addresses/validation/) for virtually [every country on Earth](https://www.shipengine.com/docs/addresses/validation/countries/), including the United States, Canada, Great Britain, Australia, Germany, France, Norway, Spain, Sweden, Israel, Italy, and over 160 others. 
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
/// A get account images by id response body
/// </summary>
//[DataContract(Name = "get_account_settings_images_response_body")]
public partial class GetAccountSettingsImagesResponseBody
{
//    
//    /// <summary>
//    /// The image type
//    /// </summary>
//    
//    /// <value>The image type</value>
//    
//    public static class ImageContentTypeEnum
//    {
//        private static readonly HashSet<string> _values = new()
//        {
//            
//            
//            "image/png",
//            
//            "image/jpeg",
//            
//            
//        };
//
//        
//        
//        
//        public static string DefaultValue => Png;
//        
//        
//        /// <summary>
//        /// Enum Png for value: image/png
//        /// </summary>
//        public static string Png { get; } = "image/png";
//        
//
//        
//        
//        
//        
//        /// <summary>
//        /// Enum Jpeg for value: image/jpeg
//        /// </summary>
//        public static string Jpeg { get; } = "image/jpeg";
//        
//        
//        
//
//        /// <summary>
//        /// Is the given value a valid ImageContentTypeEnum?
//        /// </summary>
//        public static bool IsValid(string value)
//        {
//            return _values.Contains(value);
//        }
//    }
//    




    /// <summary>
    /// The image type
    /// </summary>
    /// <value>The image type</value>
    [JsonConverter(typeof(ImageContentTypeEnumJsonConverter))]
    public class ImageContentTypeEnum
    {
        private string _value;

        internal ImageContentTypeEnum() {
            _value = "image/png";
        }

        public ImageContentTypeEnum(string value) {
          
        }

        /// <summary>
        /// Enum Png for value: image/png
        /// </summary>
        public static ImageContentTypeEnum Png { get; } = new("image/png");


        /// <summary>
        /// Enum Jpeg for value: image/jpeg
        /// </summary>
        public static ImageContentTypeEnum Jpeg { get; } = new("image/jpeg");


        public override string ToString() => _value;
    }

    internal class ImageContentTypeEnumJsonConverter : JsonConverter<ImageContentTypeEnum>
    {
        public override ImageContentTypeEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
            reader.TokenType == JsonTokenType.String ? new ImageContentTypeEnum(reader.GetString()) : null;

        public override void Write(Utf8JsonWriter writer, ImageContentTypeEnum value, JsonSerializerOptions options) =>
            writer.WriteStringValue(value.ToString());

        public override bool CanConvert(Type typeToConvert) =>
            typeToConvert == typeof(ImageContentTypeEnum);
    }


    /// <summary>
    /// The image type  CLOVUS
    /// </summary>
    /// <value>The image type</value>
    [JsonPropertyName("image_content_type")]
    public ImageContentTypeEnum? ImageContentType { get; set; }
    /// <summary>
    /// A string that uniquely identifies the image. This ID is generated by ShipEngine when the image is uploaded. 
    /// </summary>
    /// <value>A string that uniquely identifies the image. This ID is generated by ShipEngine when the image is uploaded. </value>
    /// <example>
    /// img_DtBXupDBxREpHnwEXhTfgK
    /// </example>
    [JsonPropertyName("label_image_id")]
    public string LabelImageId { get; private set; }

    /// <summary>
    /// A human readable name for the image. 
    /// </summary>
    /// <value>A human readable name for the image. </value>
    /// <example>
    /// My logo
    /// </example>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Indicates whether this image is set as default. 
    /// </summary>
    /// <value>Indicates whether this image is set as default. </value>
    /// <example>
    /// false
    /// </example>
    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }

    /// <summary>
    /// A base64 encoded string representation of the image. 
    /// </summary>
    /// <value>A base64 encoded string representation of the image. </value>
    /// <example>
    /// iVBORw0KGgoAAAANSUhEUgAAABkAAAAZCAYAAADE6YVjAAAAAXNSR0IArs4c6QAAAiVJREFUSEu91j3IeVEcB/CvSTIoBrFSikEZMdjsjExeUspgUEp5SUpeshrIgEFJJmWwMZHJQGHDhJSXTPfpnH/8ebzd56HnN93u7ZzP/f1+55x7Ob1ejxEKheByufh0HI9HrFYrcKbTKUMu5HI5BALBx5zNZoPxeAySAGc2mzF8Pp/e+BR0Ash8u93uHyKVSnH54J2Mvs8zn8//I6RO70L3xt8g70CPXvAu8hvoWQUeIj+BXpX4KcIGegWQOV4izyA2AGvkHsQW+BFyCUkkEiwWC9Ybl1W5Ls8ZMoAABCIbmE3cINFoFMFgEEajEeVyGSKRCJ1OB3q9ns5nMpmQTCaxXq9/l8loNEKj0YDX66UACYvFQq9brRYcDgdUKhU9RD/SEwLm83lEIhGUSiX0+33E4/GrU5otRMs1mUyYbDYLu90OhUJBMzhlZbPZ4Pf7odFo4HQ6b1rABqJIvV5nttstLc0pSIn2+z0tTy6XQ6FQoI/a7TZ0Ot0V9gqiiMFgYKrVKm0yieVyCZ/PB6vVSpF0Ok2zJHEqIY/HYw1RxOfzMYlE4jwoEAhAJpPBbDZf9eBwOCCVSsHtdp9f6FJ6egorlUqmVqvRfjSbTXS7XXg8nptP8Svk0RF01ROtVguSUTgchlgsPpeOZBaLxTAcDlEsFpHJZPC9XM8yoshgMGBCoRBdQWTCU7hcLjohWb5kM6rValQqlfMKfLbbb77xf/K38hf/XV9ilOpnLqvnogAAAABJRU5ErkJggg&#x3D;&#x3D;
    /// </example>
    [JsonPropertyName("image_data")]
    public string ImageData { get; set; }

    /// <summary>
    /// The date and time that the image was created in ShipEngine.
    /// </summary>
    /// <value>The date and time that the image was created in ShipEngine.</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; private set; }

    /// <summary>
    /// The date and time that the image was modified in ShipEngine.
    /// </summary>
    /// <value>The date and time that the image was modified in ShipEngine.</value>
    /// <example>
    /// 2018-09-23T15:00Z
    /// </example>
    [JsonPropertyName("modified_at")]
    public DateTime ModifiedAt { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("class GetAccountSettingsImagesResponseBody {\n");
        sb.Append("  LabelImageId: ").Append(LabelImageId).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
        sb.Append("  ImageContentType: ").Append(ImageContentType).Append("\n");
        sb.Append("  ImageData: ").Append(ImageData).Append("\n");
        sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
        sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
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

