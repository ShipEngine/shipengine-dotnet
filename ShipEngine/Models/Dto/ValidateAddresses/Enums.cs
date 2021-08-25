using System.Runtime.Serialization;

namespace ShipEngineSDK.ValidateAddresses
{
    public enum AddressResidentialIndicator
    {
        [EnumMember(Value = "unknown")]
        Unknown,

        [EnumMember(Value = "yes")]
        Yes,

        [EnumMember(Value = "no")]
        No,
    }

    public enum AddressValidationResult
    {
        [EnumMember(Value = "unverified")]
        Unverified,

        [EnumMember(Value = "verified")]
        Verified,

        [EnumMember(Value = "warning")]
        Warning,

        [EnumMember(Value = "error")]
        Error
    }

    public enum ValidationMessageType
    {
        Info,
        Warning,
        Error
    }

    public enum ValidationMessageDetailCode
    {
        [EnumMember(Value = "unsupported_country")]
        UnsupportedCountry,

        [EnumMember(Value = "non_supported_country")]
        NonSupportedCountry,

        [EnumMember(Value = "minimum_postal_code_verification_failed")]
        MinimumPostalCodeVerificationFailed,

        [EnumMember(Value = "street_does_not_match_unique_street_name")]
        StreetDoesNotMatchUniqueStreetName,

        [EnumMember(Value = "multiple_directionals")]
        MultipleDirectionals,

        [EnumMember(Value = "multiple_matches")]
        MultipleMatches,

        [EnumMember(Value = "suite_not_valid")]
        SuiteNotValid,

        [EnumMember(Value = "suite_missing")]
        SuiteMissing,

        [EnumMember(Value = "incompatible_paired_labels")]
        IncompatiblePairedLabels,

        [EnumMember(Value = "invalid_house_number")]
        InvalidHouseNumber,

        [EnumMember(Value = "missing_house_number")]
        MissingHouseNumber,

        [EnumMember(Value = "invalid_box_number")]
        InvalidBoxNumber,

        [EnumMember(Value = "invalid_charge_event")]
        InvalidChargeEvent,

        [EnumMember(Value = "missing_box_number")]
        MissingBoxNumber,

        [EnumMember(Value = "missing_cmra_or_private_mail_box_number")]
        MissingCmraOrPrivateMailBoxNumber,

        [EnumMember(Value = "suite_has_no_secondaries")]
        SuiteHasNoSecondaries,

        [EnumMember(Value = "postal_code_changed_or_added")]
        PostalCodeChangedOrAdded,

        [EnumMember(Value = "state_province_changed_or_added")]
        StateProvinceChangedOrAdded,

        [EnumMember(Value = "city_locality_changed_or_added")]
        CityLocalityChangedOrAdded,

        [EnumMember(Value = "urbanization_changed")]
        UrbanizationChanged,

        [EnumMember(Value = "street_name_spelling_changed_or_added")]
        StreetNameSpellingChangedOrAdded,

        [EnumMember(Value = "street_name_type_changed_or_added")]
        StreetNameTypeChangedOrAdded,

        [EnumMember(Value = "street_direction_changed_or_added")]
        StreetDirectionChangedOrAdded,

        [EnumMember(Value = "suite_type_changed_or_added")]
        SuiteTypeChangedOrAdded,

        [EnumMember(Value = "suite_unit_number_changed_or_added")]
        SuiteUnitNumberChangedOrAdded,

        [EnumMember(Value = "double_dependent_locality_changed_or_added")]
        DoubleDependentLocalityChangedOrAdded,

        [EnumMember(Value = "subadministrative_area_changed_or_added")]
        SubadministrativeAreaChangedOrAdded,

        [EnumMember(Value = "subnational_area_changed_or_added")]
        SubnationalAreaChangedOrAdded,

        [EnumMember(Value = "po_box_changed_or_added")]
        PoBoxChangedOrAdded,

        [EnumMember(Value = "premise_type_changed_or_added")]
        PremiseTypeChangedOrAdded,

        [EnumMember(Value = "house_number_changed")]
        HouseNumberChanged,

        [EnumMember(Value = "organization_changed_or_added")]
        OrganizationChangedOrAdded,

        [EnumMember(Value = "partially_verified_to_state_level")]
        PartiallyVerifiedToStateLevel,

        [EnumMember(Value = "partially_verified_to_city_level")]
        PartiallyVerifiedToCityLevel,

        [EnumMember(Value = "partially_verified_to_street_level")]
        PartiallyVerifiedToStreetLevel,

        [EnumMember(Value = "partially_verified_to_premise_level")]
        PartiallyVerifiedToPremiseLevel,

        [EnumMember(Value = "verified_to_state_level")]
        VerifiedToStateLevel,

        [EnumMember(Value = "verified_to_city_level")]
        VerifiedToCityLevel,

        [EnumMember(Value = "verified_to_street_level")]
        VerifiedToStreetLevel,

        [EnumMember(Value = "verified_to_premise_level")]
        VerifiedToPremiseLevel,

        [EnumMember(Value = "verified_to_suite_level")]
        VerifiedToSuiteLevel,

        [EnumMember(Value = "coded_to_street_lavel")]
        CodedToStreetLavel,

        [EnumMember(Value = "coded_to_neighborhood_level")]
        CodedToNeighborhoodLevel,

        [EnumMember(Value = "coded_to_community_level")]
        CodedToCommunityLevel,

        [EnumMember(Value = "coded_to_state_level")]
        CodedToStateLevel,

        [EnumMember(Value = "coded_to_rooftop_level")]
        CodedToRooftopLevel,

        [EnumMember(Value = "coded_to_rooftop_interpolation_level")]
        CodedToRooftopInterpolationLevel,

        [EnumMember(Value = "name_max_length_exceeded")]
        NameMaxLengthExceeded,

        [EnumMember(Value = "phone_max_length_exceeded")]
        PhoneMaxLengthExceeded,

        [EnumMember(Value = "company_name_max_length_exceeded")]
        CompanyNameMaxLengthExceeded,

        [EnumMember(Value = "line1_min_max_length")]
        Line1MinMaxLength,

        [EnumMember(Value = "line2_max_length_exceeded")]
        Line2MaxLengthExceeded,

        [EnumMember(Value = "line3_max_length_exceeded")]
        Line3MaxLengthExceeded,

        [EnumMember(Value = "city_locality_max_length_exceeded")]
        CityLocalityMaxLengthExceeded,

        [EnumMember(Value = "state_province_max_length_exceeded")]
        StateProvinceMaxLengthExceeded,

        [EnumMember(Value = "invalid_postal_code")]
        InvalidPostalCode,

        [EnumMember(Value = "country_invalid_length")]
        CountryInvalidLength,

        [EnumMember(Value = "address_not_found")]
        AddressNotFound,
    }
}