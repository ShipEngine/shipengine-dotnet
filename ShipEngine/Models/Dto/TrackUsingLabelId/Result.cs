#nullable disable

using ShipEngineSDK.Common.Enums;
using System.Collections.Generic;
namespace ShipEngineSDK.TrackUsingLabelId.Result
{
    /// <summary>
    /// Tracking information results
    /// </summary>
    public class TrackUsingLabelIdResult
    {
        ///<summary>
        ///A tracking number for a package. The format depends on the carrier.
        ///</summary>
        public string TrackingNumber { get; set; }

        ///<summary>
        ///Status Code
        ///</summary>
        public TrackingStatusCode StatusCode { get; set; }

        ///<summary>
        ///Status Description
        ///</summary>
        public TrackingStatusDescription StatusDescription { get; set; }

        ///<summary>
        ///Carrier Detail Code
        ///</summary>
        public string CarrierDetailCode { get; set; }

        ///<summary>
        ///Carrier Status Code
        ///</summary>
        public string CarrierStatusCode { get; set; }

        ///<summary>
        ///Carrier Status Description
        ///</summary>
        public string CarrierStatusDescription { get; set; }

        ///<summary>
        ///An <see href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601</see> string that represents a date and time.
        ///</summary>
        public string ShipDate { get; set; }

        ///<summary>
        ///An <see href="https://en.wikipedia.org/wiki/ISO_8601">ISO 8601</see> string that represents a date and time.
        ///</summary>
        public string EstimatedDeliveryDate { get; set; }

        ///<summary>
        ///An ISO 8601 string that represents a date and time.
        ///@see https://en.wikipedia.org/wiki/ISO_8601
        ///</summary>
        public string ActualDeliveryDate { get; set; }

        ///<summary>
        ///Exception description
        ///</summary>
        public string ExceptionDescription { get; set; }

        ///<summary>
        ///The events that have occured during the lifetime of this tracking number.
        ///</summary>
        public List<TrackingEvent> Events { get; set; }
    }

    /// <summary>
    /// Tracking Event
    /// </summary>
    public class TrackingEvent
    {
        ///<summary>
        ///Timestamp for carrier event
        ///</summary>
        public string OccurredAt { get; set; }

        ///<summary>
        ///Carrier timestamp for the event, it is assumed to be the local time of where the event occurred.
        ///</summary>
        public string CarrierOccurredAt { get; set; }

        ///<summary>
        ///Event description
        ///</summary>
        public string Description { get; set; }

        ///<summary>
        ///City Locality
        ///</summary>
        public string CityLocality { get; set; }

        ///<summary>
        ///State Province
        ///</summary>
        public string StateProvince { get; set; }

        ///<summary>
        ///Postal Code
        ///</summary>
        public string PostalCode { get; set; }

        ///<summary>
        ///The ISO 3166 <see href="https://en.wikipedia.org/wiki/List_of_ISO_3166_country_codes">country code</see>
        ///</summary>
        public string CountryCode { get; set; }

        ///<summary>
        ///Company Name
        ///</summary>
        public string CompanyName { get; set; }

        ///<summary>
        ///Signer information
        ///</summary>
        public string Signer { get; set; }

        ///<summary>
        ///Event Code
        ///</summary>
        public string EventCode { get; set; }

        ///<summary>
        ///Event status code
        ///</summary>
        public string StatusCode { get; set; }

        ///<summary>
        ///Carrier Status Code
        ///</summary>
        public string CarrierStatusCode { get; set; }

        ///<summary>
        ///Carrier Detail Code
        ///</summary>
        public string CarrierDetailCode { get; set; }

        ///<summary>
        ///Latitude coordinate of tracking event
        ///</summary>
        public double? Latitude { get; set; }

        ///<summary>
        ///Longitude coordinate of tracking event
        ///</summary>
        public double? Longitude { get; set; }
    }

}