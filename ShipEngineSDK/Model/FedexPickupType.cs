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
    /// Tax identifier type for customs declaration  |Pickup Type               |Description |- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;none&#x60;                    | Not specified |&#x60;regular_pickup&#x60;          | You already have a daily pickup scheduled with FedEx |&#x60;request_courier&#x60;         | You will call FedEx to request a courier |&#x60;drop_box&#x60;                | You will drop-off packages in a FedEx drop box |&#x60;business_service_center&#x60; | You will drop-off packages at an authorized FedEx business service center |&#x60;station&#x60;                 | You will drop-off the package at a FedEx Station 
    /// </summary>
    /// <value>Tax identifier type for customs declaration  |Pickup Type               |Description |- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- |&#x60;none&#x60;                    | Not specified |&#x60;regular_pickup&#x60;          | You already have a daily pickup scheduled with FedEx |&#x60;request_courier&#x60;         | You will call FedEx to request a courier |&#x60;drop_box&#x60;                | You will drop-off packages in a FedEx drop box |&#x60;business_service_center&#x60; | You will drop-off packages at an authorized FedEx business service center |&#x60;station&#x60;                 | You will drop-off the package at a FedEx Station </value>
    public static class FedexPickupType
    {
        private static readonly HashSet<string> _values = new()
        {
            "none",
            "regular_pickup",
            "request_courier",
            "drop_box",
            "business_service_center",
            "station",
        };

        public static string DefaultValue => None;
        /// <summary>
        /// Enum None for value: none
        /// </summary>
        public static string None { get; } = "none";


        /// <summary>
        /// Enum RegularPickup for value: regular_pickup
        /// </summary>
        public static string RegularPickup { get; } = "regular_pickup";


        /// <summary>
        /// Enum RequestCourier for value: request_courier
        /// </summary>
        public static string RequestCourier { get; } = "request_courier";


        /// <summary>
        /// Enum DropBox for value: drop_box
        /// </summary>
        public static string DropBox { get; } = "drop_box";


        /// <summary>
        /// Enum BusinessServiceCenter for value: business_service_center
        /// </summary>
        public static string BusinessServiceCenter { get; } = "business_service_center";


        /// <summary>
        /// Enum Station for value: station
        /// </summary>
        public static string Station { get; } = "station";


        /// <summary>
        /// Is the given value a valid ?
        /// </summary>
        public static bool IsValid(string value)
        {
            return _values.Contains(value);
        }
    }
