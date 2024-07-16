using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ShipEngineSDK
{
    /// <summary>
    /// Indicates the specific error that occurred.
    /// </summary>
    [JsonStringEnumMemberConverterOptions(deserializationFailureFallbackValue: Unspecified)]
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ErrorCode
    {
        /// <summary>
        /// Only certain carriers support pre-paid balances. So you can only add funds to those carriers.
        /// If you attempt to add funds to a carrier that doesn't support it, then you'll get this error code.
        /// </summary>
        [EnumMember(Value = "auto_fund_not_supported")]
        AutoFundNotSupported,

        /// <summary>
        /// Once a batch has started processing, it cannot be modified. Attempting to modify it will cause this error.
        /// </summary>
        [EnumMember(Value = "batch_cannot_be_modified")]
        BatchCannotBeModified,

        /// <summary>
        /// You attempted to perform an operation on multiple shipments from different carriers.
        /// Try performing separate operations for each carrier instead.
        /// </summary>
        [EnumMember(Value = "carrier_conflict")]
        CarrierConflict,

        /// <summary>
        /// You have selected to insure a package, however the carrier you are attempting to create a shipping label
        /// for does not support declaring insurance on shipments.
        /// </summary>
        [EnumMember(Value = "carrier_insurance_not_supported")]
        CarrierInsuranceNotSupported,

        /// <summary>
        /// This error means that you're trying to use a carrier that hasn't been setup yet.
        /// You can setup carriers from your ShipEngine dashboard, or via the API.
        /// </summary>
        [EnumMember(Value = "carrier_not_connected")]
        CarrierNotConnected,

        /// <summary>
        /// The operation you are performing isn't supported by the specified carrier.
        /// </summary>
        [EnumMember(Value = "carrier_not_supported")]
        CarrierNotSupported,

        /// <summary>
        /// Some forms of delivery confirmation aren't supported by some carriers.
        /// This error means that the combination of carrier and delivery confirmation are not supported.
        /// </summary>
        [EnumMember(Value = "confirmation_not_supported")]
        ConfirmationNotSupported,

        /// <summary>
        /// When shipping internationally, you must add a customs declaration which outlines the items you are shipping.
        /// This is helpful to customs agents when your package enters it's destination country. This error arises when you
        /// do not add a customs declaration to your shipment before attempting to create a shipping label for an
        /// international shipment.
        /// </summary>
        [EnumMember(Value = "customs_items_required")]
        CustomsItemsRequired,

        /// <summary>
        /// This error means that two or more fields in your API request are mutually exclusive or contain conflicting values.
        /// The error will include a fields array that lists the conflicting fields.
        /// </summary>
        [EnumMember(Value = "field_conflict")]
        FieldConflict,

        /// <summary>
        /// A required field is missing or empty. The field_name property indicates which field is missing.
        /// Note that some fields are conditionally required, based on the values of other fields or the type of operation being performed.
        /// </summary>
        [EnumMember(Value = "field_value_required")]
        FieldValueRequired,

        /// <summary>
        /// You attempted to perform an operation that you don't have permissions to do. Check your API key to ensure that you're using the correct one. Or contact our support team to ensure that your account has the necessary permissions.
        /// </summary>
        [EnumMember(Value = "forbidden")]
        Forbidden,

        /// <summary>
        /// A few parts of the ShipEngine API allow you to provide your own ID for resources.
        /// These IDs must be unique; otherwise, you'll get this error code.
        /// </summary>
        [EnumMember(Value = "identifier_conflict")]
        IdentifierConflict,

        /// <summary>
        /// When updating a resource (such as a shipment or warehouse), the ID in the URL and in the request body must match.
        /// </summary>
        [EnumMember(Value = "identifiers_must_match")]
        IdentifiersMustMatch,

        /// <summary>
        /// When creating a return label, you can optionally pair it to an outbound_label_id.
        /// The outbound label must be from the same carrier as the return label.
        /// </summary>
        [EnumMember(Value = "incompatible_paired_labels")]
        IncompatiblePairedLabels,

        /// <summary>
        /// The mailing address that you provided is invalid. Try using our address validation API to verify addresses before using them.
        /// </summary>
        [EnumMember(Value = "invalid_address")]
        InvalidAddress,

        /// <summary>
        /// You attempted to perform an operation that isn't allowed for your billing plan. Contact our sales team for assistance.
        /// </summary>
        [EnumMember(Value = "invalid_billing_plan")]
        InvalidBillingPlan,

        /// <summary>
        /// When creating a label or creating a return label, if you set the charge_event field to a value that isn't offered by the carrier,
        /// then you will receive this error. You can leave the charge_event field unset, or set it to carrier_default instead.
        /// </summary>
        [EnumMember(Value = "invalid_charge_event")]
        InvalidChargeEvent,

        /// <summary>
        /// When creating a label, if you set the date to an invalid date e.g. A date in the past
        /// </summary>
        [EnumMember(Value = "invalid_date")]
        InvalidDate,

        /// <summary>
        /// One of the fields in your API request has an invalid value. The field_name property indicates which field is invalid.
        /// </summary>
        [EnumMember(Value = "invalid_field_value")]
        InvalidFieldValue,

        /// <summary>
        /// This error is similar to invalid_field_value, but is specifically for ID fields, such as label_id, shipment_id, carrier_id, etc.
        /// The field_name property indicates which field is invalid.
        /// </summary>
        [EnumMember(Value = "invalid_identifier")]
        InvalidIdentifier,

        /// <summary>
        /// The operation you're attempting to perform is not allowed because the resource is in the wrong status.
        /// For example, if a label's status is "voided", then it cannot be included in a manifest.
        /// </summary>
        [EnumMember(Value = "invalid_status")]
        InvalidStatus,

        /// <summary>
        /// A string field in your API request is either too short or too long. The field_name property indicates which field is invalid,
        /// and the min_length and max_length properties indicate the allowed length.
        /// </summary>
        [EnumMember(Value = "invalid_string_length")]
        InvalidStringLength,

        /// <summary>
        /// Not all carriers allow you to add custom images to labels. You can only set the label_image_id for supported carriers
        /// </summary>
        [EnumMember(Value = "label_images_not_supported")]
        LabelImagesNotSupported,

        /// <summary>
        /// This error indicates a problem with your FedEx account. Please contact FedEx to resolve the issue.
        /// </summary>
        [EnumMember(Value = "meter_failure")]
        MeterFailure,

        /// <summary>
        /// Requested resource was not found
        /// </summary>
        [EnumMember(Value = "not_found")]
        NotFound,

        /// <summary>
        /// This error means that there were no rates returned for the carrier referenced in the carrier_code field.
        /// </summary>
        [EnumMember(Value = "no_rates_returned")]
        NoRatesReturned,

        /// <summary>
        /// You have exceeded a rate limit. Check the the error_source field to determine whether the rate limit was imposed by ShipEngine or by a third-party, such as a carrier. If the rate limit is from ShipEngine, then consider using bulk operations to reduce the nuber of API calls, or contact our support team about increasing your rate limit.
        /// </summary>
        [EnumMember(Value = "rate_limit_exceeded")]
        RateLimitExceeded,

        /// <summary>
        /// The API call requires a JSON request body. See the corresponding documentation page for details about the request structure.
        /// </summary>
        [EnumMember(Value = "request_body_required")]
        RequestBodyRequired,

        /// <summary>
        /// You may receive this error if you attempt to schedule a pickup for a return label.
        /// </summary>
        [EnumMember(Value = "return_label_not_supported")]
        ReturnLabelNotSupported,

        /// <summary>
        /// You may receive this error if you attempt to perform an operation that requires a subscription.
        /// Please contact our sales department to discuss a ShipEngine enterprise contract.
        /// </summary>
        [EnumMember(Value = "subscription_inactive")]
        SubscriptionInactive,

        /// <summary>
        /// Some carriers require you to accept their terms and conditions before you can use them via ShipEngine.
        /// If you get this error, then please login to the ShipEngine dashboard to read and accept the carrier's terms.
        /// </summary>
        [EnumMember(Value = "terms_not_accepted")]
        TermsNotAccepted,

        /// <summary>
        /// Resource timed out on network call.
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout,

        /// <summary>
        /// This error will occur if you attempt to track a package for a carrier that doesn't offer that service.
        /// </summary>
        [EnumMember(Value = "tracking_not_supported")]
        TrackingNotSupported,

        /// <summary>
        /// You may receive this error if your free trial period has expired and you have not upgraded your account or added billing information.
        /// </summary>
        [EnumMember(Value = "trial_expired")]
        TrialExpired,

        /// <summary>
        /// Your API key is incorrect, expired, or missing. Check our authentication guide to learn more about authentication with ShipEngine.
        /// </summary>
        [EnumMember(Value = "unauthorized")]
        Unauthorized,

        /// <summary>
        /// This error has not yet been assigned a code. See the notes above about how to handle these.
        /// </summary>
        [EnumMember(Value = "unspecified")]
        Unspecified,

        /// <summary>
        /// When verifying your account (by email, SMS, phone call, etc.) this error indicates that the verification code is incorrect. Please re-start the verification process to get a new code.
        /// </summary>
        [EnumMember(Value = "verification_failure")]
        VerificationFailure,

        /// <summary>
        /// You attempted to perform an operation on multiple shipments from different warehouses. Try performing separate operations for each warehouse instead.
        /// </summary>
        [EnumMember(Value = "warehouse_conflict")]
        WarehouseConflict,

        /// <summary>
        /// ShipEngine only allows you to have one webhook of each type. If you would like to replace a webhook with a new one, please delete the old one first.
        /// </summary>
        [EnumMember(Value = "webhook_event_type_conflict")]
        WebhookEventTypeConflict,
    }
}