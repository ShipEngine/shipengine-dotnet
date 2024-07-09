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
    /// The possible file formats in which shipping labels can be downloaded.  We recommend &#x60;pdf&#x60; format because it is supported by all carriers, whereas some carriers do not support the &#x60;png&#x60; or &#x60;zpl&#x60; formats.  |Label Format  | Supported Carriers |- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;pdf&#x60;         | All carriers |&#x60;png&#x60;         | &#x60;fedex&#x60; &lt;br&gt; &#x60;stamps_com&#x60; &lt;br&gt; &#x60;ups&#x60; &lt;br&gt; &#x60;usps&#x60; |&#x60;zpl&#x60;         | &#x60;access_worldwide&#x60; &lt;br&gt; &#x60;apc&#x60; &lt;br&gt; &#x60;asendia&#x60; &lt;br&gt; &#x60;dhl_global_mail&#x60; &lt;br&gt; &#x60;dhl_express&#x60; &lt;br&gt; &#x60;dhl_express_australia&#x60; &lt;br&gt; &#x60;dhl_express_canada&#x60; &lt;br&gt; &#x60;dhl_express_worldwide&#x60; &lt;br&gt; &#x60;dhl_express_uk&#x60; &lt;br&gt; &#x60;dpd&#x60; &lt;br&gt; &#x60;endicia&#x60; &lt;br&gt; &#x60;fedex&#x60; &lt;br&gt; &#x60;fedex_uk&#x60; &lt;br&gt; &#x60;firstmile&#x60; &lt;br&gt; &#x60;imex&#x60; &lt;br&gt; &#x60;newgistics&#x60; &lt;br&gt; &#x60;ontrac&#x60; &lt;br&gt; &#x60;rr_donnelley&#x60; &lt;br&gt; &#x60;stamps_com&#x60; &lt;br&gt; &#x60;ups&#x60; &lt;br&gt; &#x60;usps&#x60; 
    /// </summary>
    /// <value>The possible file formats in which shipping labels can be downloaded.  We recommend &#x60;pdf&#x60; format because it is supported by all carriers, whereas some carriers do not support the &#x60;png&#x60; or &#x60;zpl&#x60; formats.  |Label Format  | Supported Carriers |- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;pdf&#x60;         | All carriers |&#x60;png&#x60;         | &#x60;fedex&#x60; &lt;br&gt; &#x60;stamps_com&#x60; &lt;br&gt; &#x60;ups&#x60; &lt;br&gt; &#x60;usps&#x60; |&#x60;zpl&#x60;         | &#x60;access_worldwide&#x60; &lt;br&gt; &#x60;apc&#x60; &lt;br&gt; &#x60;asendia&#x60; &lt;br&gt; &#x60;dhl_global_mail&#x60; &lt;br&gt; &#x60;dhl_express&#x60; &lt;br&gt; &#x60;dhl_express_australia&#x60; &lt;br&gt; &#x60;dhl_express_canada&#x60; &lt;br&gt; &#x60;dhl_express_worldwide&#x60; &lt;br&gt; &#x60;dhl_express_uk&#x60; &lt;br&gt; &#x60;dpd&#x60; &lt;br&gt; &#x60;endicia&#x60; &lt;br&gt; &#x60;fedex&#x60; &lt;br&gt; &#x60;fedex_uk&#x60; &lt;br&gt; &#x60;firstmile&#x60; &lt;br&gt; &#x60;imex&#x60; &lt;br&gt; &#x60;newgistics&#x60; &lt;br&gt; &#x60;ontrac&#x60; &lt;br&gt; &#x60;rr_donnelley&#x60; &lt;br&gt; &#x60;stamps_com&#x60; &lt;br&gt; &#x60;ups&#x60; &lt;br&gt; &#x60;usps&#x60; </value>
    public static class LabelFormat
    {
        private static readonly HashSet<string> _values = new()
        {
            "pdf",
            "png",
            "zpl",
        };

        public static string DefaultValue => Pdf;
        /// <summary>
        /// Enum Pdf for value: pdf
        /// </summary>
        public static string Pdf { get; } = "pdf";


        /// <summary>
        /// Enum Png for value: png
        /// </summary>
        public static string Png { get; } = "png";


        /// <summary>
        /// Enum Zpl for value: zpl
        /// </summary>
        public static string Zpl { get; } = "zpl";


        /// <summary>
        /// Is the given value a valid ?
        /// </summary>
        public static bool IsValid(string value)
        {
            return _values.Contains(value);
        }
    }
