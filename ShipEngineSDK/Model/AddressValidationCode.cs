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
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

    /// <summary>
    /// The error codes that can be returned by the address validation API
    /// </summary>
    /// <value>The error codes that can be returned by the address validation API</value>
    public static class AddressValidationCode
    {
        private static readonly HashSet<string> _values = new()
        {
            "a1000",
            "a1001",
            "a1002",
            "a1003",
            "a1004",
            "a1005",
            "a1006",
            "a1007",
            "a1008",
            "r1000",
            "r1001",
            "r1002",
            "r1003",
        };

        public static string DefaultValue => A1000;
        /// <summary>
        /// Enum A1000 for value: a1000
        /// </summary>
        public static string A1000 { get; } = "a1000";


        /// <summary>
        /// Enum A1001 for value: a1001
        /// </summary>
        public static string A1001 { get; } = "a1001";


        /// <summary>
        /// Enum A1002 for value: a1002
        /// </summary>
        public static string A1002 { get; } = "a1002";


        /// <summary>
        /// Enum A1003 for value: a1003
        /// </summary>
        public static string A1003 { get; } = "a1003";


        /// <summary>
        /// Enum A1004 for value: a1004
        /// </summary>
        public static string A1004 { get; } = "a1004";


        /// <summary>
        /// Enum A1005 for value: a1005
        /// </summary>
        public static string A1005 { get; } = "a1005";


        /// <summary>
        /// Enum A1006 for value: a1006
        /// </summary>
        public static string A1006 { get; } = "a1006";


        /// <summary>
        /// Enum A1007 for value: a1007
        /// </summary>
        public static string A1007 { get; } = "a1007";


        /// <summary>
        /// Enum A1008 for value: a1008
        /// </summary>
        public static string A1008 { get; } = "a1008";


        /// <summary>
        /// Enum R1000 for value: r1000
        /// </summary>
        public static string R1000 { get; } = "r1000";


        /// <summary>
        /// Enum R1001 for value: r1001
        /// </summary>
        public static string R1001 { get; } = "r1001";


        /// <summary>
        /// Enum R1002 for value: r1002
        /// </summary>
        public static string R1002 { get; } = "r1002";


        /// <summary>
        /// Enum R1003 for value: r1003
        /// </summary>
        public static string R1003 { get; } = "r1003";


        /// <summary>
        /// Is the given value a valid ?
        /// </summary>
        public static bool IsValid(string value)
        {
            return _values.Contains(value);
        }
    }
