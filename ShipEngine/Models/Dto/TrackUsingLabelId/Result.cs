


using System.Collections.Generic;
using System.Text.Json.Serialization;
/**
* The Tracking information and events associated with a label
* @see https://www.shipengine.com/docs/tracking/track-by-label-id/
*/
namespace ShipEngineSDK.TrackUsingLabelId.Result
{
    public class TrackUsingLabelIdResult
    {
        /**
        * A tracking number for a package. The format depends on the carrier.
*/
        [JsonPropertyName("tracking_number")]

        public string TrackingNumber { get; set; }

        /**
        * Status Code
*/
        // statusCode: "AC" | "IT" | "DE" | "EX" | "AT" | "UN";
        [JsonPropertyName("status_code")]

        public string StatusCode { get; set; }

        /**
        * Status Description
*/
        // statusDescription:
        //     | "Accepted"
        //     | "Attempted Delivery"
        //     | "Delivered"
        //     | "Exception"
        //     | "In Transit"
        //     | "Unknown";

        [JsonPropertyName("status_description")]
        public string StatusDescription { get; set; }

        /**
        * Carrier Detail Code
*/
        [JsonPropertyName("carrier_detail_code")]

        public string CarrierDetailCode { get; set; }

        /**
        * Carrier Status Code
*/
        [JsonPropertyName("carrier_status_code")]

        public string CarrierStatusCode { get; set; }

        /**
        * Carrier Status Description
*/
        [JsonPropertyName("carrier_status_description")]

        public string CarrierStatusDescription { get; set; }

        /**
        * An ISO 8601 string that represents a date and time.
        * @see https://en.wikipedia.org/wiki/ISO_8601
*/

        [JsonPropertyName("ship_date")]

        public string ShipDate { get; set; }

        /**
        * An ISO 8601 string that represents a date and time.
        * @see https://en.wikipedia.org/wiki/ISO_8601
*/
        [JsonPropertyName("estimated_delivery_date")]

        public string EstimatedDeliveryDate { get; set; }

        /**
        * An ISO 8601 string that represents a date and time.
        * @see https://en.wikipedia.org/wiki/ISO_8601
*/
        [JsonPropertyName("actual_delivery_date")]

        public string ActualDeliveryDate { get; set; }

        /**
        * Exception description
*/
        [JsonPropertyName("exception_description")]

        public string ExceptionDescription { get; set; }

        /**
        * The events that have occured during the lifetime of this tracking number.
*/
        [JsonPropertyName("events")]

        public List<TrackingEvent> Events { get; set; }
    }

    /**
     * The events that have occurred during the lifetime of this tracking number.
     *
     * @see https://www.shipengine.com/docs/tracking/track-by-label-id/
     */
    public class TrackingEvent
    {
        /**
         * Timestamp for carrier event
         */
        [JsonPropertyName("occurred_at")]

        public string OccurredAt { get; set; }

        /**
         * Carrier timestamp for the event, it is assumed to be the local time of where the event occurred.
         */
        [JsonPropertyName("carrier_occurred_at")]

        public string CarrierOccurredAt { get; set; }

        /**
         * Event description
         */
        [JsonPropertyName("description")]

        public string Description { get; set; }

        /**
         * City Locality
         */
        [JsonPropertyName("city_locality")]

        public string CityLocality { get; set; }

        /**
         * State Province
         */
        [JsonPropertyName("state_province")]

        public string StateProvince { get; set; }

        /**
         * Postal Code
         */
        [JsonPropertyName("postal_code")]

        public string PostalCode { get; set; }

        /**
         * The ISO 3166 country code
         *
         * @see https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes
         */
        [JsonPropertyName("country_code")]

        public string CountryCode { get; set; }

        /**
         * Company Name
         */
        [JsonPropertyName("company_name")]

        public string CompanyName { get; set; }

        /**
         * Signer information
        [JsonPropertyName("postal_code")]
         */
        [JsonPropertyName("signer")]

        public string Signer { get; set; }

        /**
         * Event Code
         */
        [JsonPropertyName("event_code")]

        public string EventCode { get; set; }

        /**
         * Event status code
         */
        [JsonPropertyName("status_code")]

        public string StatusCode { get; set; }

        /**
         * Carrier Status Code
         */
        [JsonPropertyName("carrier_status_code")]

        public string CarrierStatusCode { get; set; }

        /**
         * Carrier Detail Code
         */
        [JsonPropertyName("carrier_detail_code")]

        public string CarrierDetailCode { get; set; }

        /**
         * Latitude coordinate of tracking event
         */
        [JsonPropertyName("latitude")]

        public double? Latitude { get; set; }

        /**
         * Longitude coordinate of tracking event
         */
        [JsonPropertyName("longitude")]

        public double? Longitude { get; set; }
    }

}