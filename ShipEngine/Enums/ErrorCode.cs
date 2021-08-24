using System.Runtime.Serialization;

namespace ShipEngineSDK
{
    public enum ErrorCode
    {
        [EnumMember(Value = "auto_fund_not_supported")]
        AutoFundNotSupported,

        [EnumMember(Value = "batch_cannot_be_modified")]
        BatchCannotBeModified,

        [EnumMember(Value = "carrier_conflict")]
        CarrierConflict,

        [EnumMember(Value = "carrier_not_connected")]
        CarrierNotConnected,

        [EnumMember(Value = "carrier_not_supported")]
        CarrierNotSupported,

        [EnumMember(Value = "confirmation_not_supported")]
        ConfirmationNotSupported,

        [EnumMember(Value = "field_conflict")]
        FieldConflict,

        [EnumMember(Value = "field_value_required")]
        FieldValueRequired,

        [EnumMember(Value = "forbidden")]
        Forbidden,

        [EnumMember(Value = "identifier_conflict")]
        IdentifierConflict,

        [EnumMember(Value = "identifiers_must_match")]
        IdentifiersMustMatch,

        [EnumMember(Value = "incompatible_paired_labels")]
        IncompatiblePairedLabels,

        [EnumMember(Value = "invalid_address")]
        InvalidAddress,

        [EnumMember(Value = "invalid_billing_plan")]
        InvalidBillingPlan,

        [EnumMember(Value = "invalid_charge_event")]
        InvalidChargeEvent,

        [EnumMember(Value = "invalid_field_value")]
        InvalidFieldValue,

        [EnumMember(Value = "invalid_identifier")]
        InvalidIdentifier,

        [EnumMember(Value = "invalid_status")]
        InvalidStatus,

        [EnumMember(Value = "invalid_string_length")]
        InvalidStringLength,

        [EnumMember(Value = "label_images_not_supported")]
        LabelImagesNotSupported,

        [EnumMember(Value = "meter_failure")]
        MeterFailure,

        [EnumMember(Value = "not_found")]
        NotFound,

        [EnumMember(Value = "rate_limit_exceeded")]
        RateLimitExceeded,

        [EnumMember(Value = "request_body_required")]
        RequestBodyRequired,

        [EnumMember(Value = "return_label_not_supported")]
        ReturnLabelNotSupported,

        [EnumMember(Value = "subscription_inactive")]
        SubscriptionInactive,

        [EnumMember(Value = "terms_not_accepted")]
        TermsNotAccepted,

        [EnumMember(Value = "timeout")]
        Timeout,

        [EnumMember(Value = "tracking_not_supported")]
        TrackingNotSupported,

        [EnumMember(Value = "trial_expired")]
        TrialExpired,

        [EnumMember(Value = "unauthorized")]
        Unauthorized,

        [EnumMember(Value = "unspecified")]
        Unspecified,

        [EnumMember(Value = "verification_failure")]
        VerificationFailure,

        [EnumMember(Value = "warehouse_conflict")]
        WarehouseConflict,

        [EnumMember(Value = "webhook_event_type_conflict")]
        WebhookEventTypeConflict,
    }
}