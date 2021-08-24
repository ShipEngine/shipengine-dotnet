


using System.Collections.Generic;
/**
* The Tracking information and events associated with a label
* @see https://www.shipengine.com/docs/tracking/track-by-label-id/
*/
namespace ShipEngineSDK.TrackUsingCarrierCodeAndTrackingNumber.Result
{
    public class TrackUsingCarrierCodeAndTrackingNumberResult
    {
        /**
        * A tracking number for a package. The format depends on the carrier.
*/
        public string TrackingNumber { get; set; }

        /**
        * Status Code
*/
        // statusCode: "AC" | "IT" | "DE" | "EX" | "AT" | "UN";
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
        public string StatusDescription { get; set; }

        /**
        * Carrier Detail Code
*/
        public string CarrierDetailCode { get; set; }

        /**
        * Carrier Status Code
*/
        public string CarrierStatusCode { get; set; }

        /**
        * Carrier Status Description
*/
        public string CarrierStatusDescription { get; set; }

        /**
        * An ISO 8601 string that represents a date and time.
        * @see https://en.wikipedia.org/wiki/ISO_8601
*/

        public string ShipDate { get; set; }

        /**
        * An ISO 8601 string that represents a date and time.
        * @see https://en.wikipedia.org/wiki/ISO_8601
*/
        public string EstimatedDeliveryDate { get; set; }

        /**
        * An ISO 8601 string that represents a date and time.
        * @see https://en.wikipedia.org/wiki/ISO_8601
*/
        public string ActualDeliveryDate { get; set; }

        /**
        * Exception description
*/
        public string ExceptionDescription { get; set; }

        /**
        * The events that have occured during the lifetime of this tracking number.
*/
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
        public string OccurredAt { get; set; }

        /**
         * Carrier timestamp for the event, it is assumed to be the local time of where the event occurred.
         */
        public string CarrierOccurredAt { get; set; }

        /**
         * Event description
         */
        public string Description { get; set; }

        /**
         * City Locality
         */
        public string CityLocality { get; set; }

        /**
         * State Province
         */
        public string StateProvince { get; set; }

        /**
         * Postal Code
         */
        public string PostalCode { get; set; }

        /**
         * The ISO 3166 country code
         *
         * @see https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes
         */
        public string CountryCode { get; set; }

        /**
         * Company Name
         */
        public string CompanyName { get; set; }

        /**
         * Signer information         */
        public string Signer { get; set; }

        /**
         * Event Code
         */
        public string EventCode { get; set; }

        /**
         * Event status code
         */
        public string StatusCode { get; set; }

        /**
         * Carrier Status Code
         */
        public string CarrierStatusCode { get; set; }

        /**
         * Carrier Detail Code
         */
        public string CarrierDetailCode { get; set; }

        /**
         * Latitude coordinate of tracking event
         */
        public double? Latitude { get; set; }

        /**
         * Longitude coordinate of tracking event
         */
        public double? Longitude { get; set; }
    }

}