/*
 * ShipEngine API
 *
 * The version of the OpenAPI document: 1.1.202406212006
 * Contact: sales@shipengine.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;

namespace ShipEngineSDK.Model;

/// <summary>
/// The detailed error codes that can be returned by the address validation API
/// </summary>
/// <value>The detailed error codes that can be returned by the address validation API</value>
[JsonConverter(typeof(AddressValidationDetailCodeJsonConverter))]
public class AddressValidationDetailCode
{
    private string _value;

    /// <summary>
    /// Create a new instance of AddressValidationDetailCode with a predefined value.
    /// </summary>
    internal AddressValidationDetailCode()
    {
        _value = "unsupported_country";
    }

    /// <summary>
    /// Create a new instance of AddressValidationDetailCode with a custom value.
    /// </summary>
    /// <param name="value">The value of the AddressValidationDetailCode</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public AddressValidationDetailCode(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum UnsupportedCountry for value: unsupported_country
    /// </summary>
    public static AddressValidationDetailCode UnsupportedCountry { get; } = new("unsupported_country");


    /// <summary>
    /// Enum NonSupportedCountry for value: non_supported_country
    /// </summary>
    public static AddressValidationDetailCode NonSupportedCountry { get; } = new("non_supported_country");


    /// <summary>
    /// Enum MinimumPostalCodeVerificationFailed for value: minimum_postal_code_verification_failed
    /// </summary>
    public static AddressValidationDetailCode MinimumPostalCodeVerificationFailed { get; } = new("minimum_postal_code_verification_failed");


    /// <summary>
    /// Enum StreetDoesNotMatchUniqueStreetName for value: street_does_not_match_unique_street_name
    /// </summary>
    public static AddressValidationDetailCode StreetDoesNotMatchUniqueStreetName { get; } = new("street_does_not_match_unique_street_name");


    /// <summary>
    /// Enum MultipleDirectionals for value: multiple_directionals
    /// </summary>
    public static AddressValidationDetailCode MultipleDirectionals { get; } = new("multiple_directionals");


    /// <summary>
    /// Enum MultipleMatches for value: multiple_matches
    /// </summary>
    public static AddressValidationDetailCode MultipleMatches { get; } = new("multiple_matches");


    /// <summary>
    /// Enum SuiteNotValid for value: suite_not_valid
    /// </summary>
    public static AddressValidationDetailCode SuiteNotValid { get; } = new("suite_not_valid");


    /// <summary>
    /// Enum SuiteMissing for value: suite_missing
    /// </summary>
    public static AddressValidationDetailCode SuiteMissing { get; } = new("suite_missing");


    /// <summary>
    /// Enum IncompatiblePairedLabels for value: incompatible_paired_labels
    /// </summary>
    public static AddressValidationDetailCode IncompatiblePairedLabels { get; } = new("incompatible_paired_labels");


    /// <summary>
    /// Enum InvalidHouseNumber for value: invalid_house_number
    /// </summary>
    public static AddressValidationDetailCode InvalidHouseNumber { get; } = new("invalid_house_number");


    /// <summary>
    /// Enum MissingHouseNumber for value: missing_house_number
    /// </summary>
    public static AddressValidationDetailCode MissingHouseNumber { get; } = new("missing_house_number");


    /// <summary>
    /// Enum InvalidBoxNumber for value: invalid_box_number
    /// </summary>
    public static AddressValidationDetailCode InvalidBoxNumber { get; } = new("invalid_box_number");


    /// <summary>
    /// Enum InvalidChargeEvent for value: invalid_charge_event
    /// </summary>
    public static AddressValidationDetailCode InvalidChargeEvent { get; } = new("invalid_charge_event");


    /// <summary>
    /// Enum MissingBoxNumber for value: missing_box_number
    /// </summary>
    public static AddressValidationDetailCode MissingBoxNumber { get; } = new("missing_box_number");


    /// <summary>
    /// Enum MissingCmraOrPrivateMailBoxNumber for value: missing_cmra_or_private_mail_box_number
    /// </summary>
    public static AddressValidationDetailCode MissingCmraOrPrivateMailBoxNumber { get; } = new("missing_cmra_or_private_mail_box_number");


    /// <summary>
    /// Enum SuiteHasNoSecondaries for value: suite_has_no_secondaries
    /// </summary>
    public static AddressValidationDetailCode SuiteHasNoSecondaries { get; } = new("suite_has_no_secondaries");


    /// <summary>
    /// Enum PostalCodeChangedOrAdded for value: postal_code_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode PostalCodeChangedOrAdded { get; } = new("postal_code_changed_or_added");


    /// <summary>
    /// Enum StateProvinceChangedOrAdded for value: state_province_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode StateProvinceChangedOrAdded { get; } = new("state_province_changed_or_added");


    /// <summary>
    /// Enum CityLocalityChangedOrAdded for value: city_locality_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode CityLocalityChangedOrAdded { get; } = new("city_locality_changed_or_added");


    /// <summary>
    /// Enum UrbanizationChanged for value: urbanization_changed
    /// </summary>
    public static AddressValidationDetailCode UrbanizationChanged { get; } = new("urbanization_changed");


    /// <summary>
    /// Enum StreetNameSpellingChangedOrAdded for value: street_name_spelling_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode StreetNameSpellingChangedOrAdded { get; } = new("street_name_spelling_changed_or_added");


    /// <summary>
    /// Enum StreetNameTypeChangedOrAdded for value: street_name_type_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode StreetNameTypeChangedOrAdded { get; } = new("street_name_type_changed_or_added");


    /// <summary>
    /// Enum StreetDirectionChangedOrAdded for value: street_direction_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode StreetDirectionChangedOrAdded { get; } = new("street_direction_changed_or_added");


    /// <summary>
    /// Enum SuiteTypeChangedOrAdded for value: suite_type_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode SuiteTypeChangedOrAdded { get; } = new("suite_type_changed_or_added");


    /// <summary>
    /// Enum SuiteUnitNumberChangedOrAdded for value: suite_unit_number_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode SuiteUnitNumberChangedOrAdded { get; } = new("suite_unit_number_changed_or_added");


    /// <summary>
    /// Enum DoubleDependentLocalityChangedOrAdded for value: double_dependent_locality_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode DoubleDependentLocalityChangedOrAdded { get; } = new("double_dependent_locality_changed_or_added");


    /// <summary>
    /// Enum SubadministrativeAreaChangedOrAdded for value: subadministrative_area_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode SubadministrativeAreaChangedOrAdded { get; } = new("subadministrative_area_changed_or_added");


    /// <summary>
    /// Enum SubnationalAreaChangedOrAdded for value: subnational_area_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode SubnationalAreaChangedOrAdded { get; } = new("subnational_area_changed_or_added");


    /// <summary>
    /// Enum PoBoxChangedOrAdded for value: po_box_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode PoBoxChangedOrAdded { get; } = new("po_box_changed_or_added");


    /// <summary>
    /// Enum PremiseTypeChangedOrAdded for value: premise_type_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode PremiseTypeChangedOrAdded { get; } = new("premise_type_changed_or_added");


    /// <summary>
    /// Enum HouseNumberChanged for value: house_number_changed
    /// </summary>
    public static AddressValidationDetailCode HouseNumberChanged { get; } = new("house_number_changed");


    /// <summary>
    /// Enum OrganizationChangedOrAdded for value: organization_changed_or_added
    /// </summary>
    public static AddressValidationDetailCode OrganizationChangedOrAdded { get; } = new("organization_changed_or_added");


    /// <summary>
    /// Enum PartiallyVerifiedToStateLevel for value: partially_verified_to_state_level
    /// </summary>
    public static AddressValidationDetailCode PartiallyVerifiedToStateLevel { get; } = new("partially_verified_to_state_level");


    /// <summary>
    /// Enum PartiallyVerifiedToCityLevel for value: partially_verified_to_city_level
    /// </summary>
    public static AddressValidationDetailCode PartiallyVerifiedToCityLevel { get; } = new("partially_verified_to_city_level");


    /// <summary>
    /// Enum PartiallyVerifiedToStreetLevel for value: partially_verified_to_street_level
    /// </summary>
    public static AddressValidationDetailCode PartiallyVerifiedToStreetLevel { get; } = new("partially_verified_to_street_level");


    /// <summary>
    /// Enum PartiallyVerifiedToPremiseLevel for value: partially_verified_to_premise_level
    /// </summary>
    public static AddressValidationDetailCode PartiallyVerifiedToPremiseLevel { get; } = new("partially_verified_to_premise_level");


    /// <summary>
    /// Enum VerifiedToStateLevel for value: verified_to_state_level
    /// </summary>
    public static AddressValidationDetailCode VerifiedToStateLevel { get; } = new("verified_to_state_level");


    /// <summary>
    /// Enum VerifiedToCityLevel for value: verified_to_city_level
    /// </summary>
    public static AddressValidationDetailCode VerifiedToCityLevel { get; } = new("verified_to_city_level");


    /// <summary>
    /// Enum VerifiedToStreetLevel for value: verified_to_street_level
    /// </summary>
    public static AddressValidationDetailCode VerifiedToStreetLevel { get; } = new("verified_to_street_level");


    /// <summary>
    /// Enum VerifiedToPremiseLevel for value: verified_to_premise_level
    /// </summary>
    public static AddressValidationDetailCode VerifiedToPremiseLevel { get; } = new("verified_to_premise_level");


    /// <summary>
    /// Enum VerifiedToSuiteLevel for value: verified_to_suite_level
    /// </summary>
    public static AddressValidationDetailCode VerifiedToSuiteLevel { get; } = new("verified_to_suite_level");


    /// <summary>
    /// Enum CodedToStreetLavel for value: coded_to_street_lavel
    /// </summary>
    public static AddressValidationDetailCode CodedToStreetLavel { get; } = new("coded_to_street_lavel");


    /// <summary>
    /// Enum CodedToNeighborhoodLevel for value: coded_to_neighborhood_level
    /// </summary>
    public static AddressValidationDetailCode CodedToNeighborhoodLevel { get; } = new("coded_to_neighborhood_level");


    /// <summary>
    /// Enum CodedToCommunityLevel for value: coded_to_community_level
    /// </summary>
    public static AddressValidationDetailCode CodedToCommunityLevel { get; } = new("coded_to_community_level");


    /// <summary>
    /// Enum CodedToStateLevel for value: coded_to_state_level
    /// </summary>
    public static AddressValidationDetailCode CodedToStateLevel { get; } = new("coded_to_state_level");


    /// <summary>
    /// Enum CodedToRooftopLevel for value: coded_to_rooftop_level
    /// </summary>
    public static AddressValidationDetailCode CodedToRooftopLevel { get; } = new("coded_to_rooftop_level");


    /// <summary>
    /// Enum CodedToRooftopInterpolationLevel for value: coded_to_rooftop_interpolation_level
    /// </summary>
    public static AddressValidationDetailCode CodedToRooftopInterpolationLevel { get; } = new("coded_to_rooftop_interpolation_level");


    /// <summary>
    /// Enum NameMaxLengthExceeded for value: name_max_length_exceeded
    /// </summary>
    public static AddressValidationDetailCode NameMaxLengthExceeded { get; } = new("name_max_length_exceeded");


    /// <summary>
    /// Enum PhoneMaxLengthExceeded for value: phone_max_length_exceeded
    /// </summary>
    public static AddressValidationDetailCode PhoneMaxLengthExceeded { get; } = new("phone_max_length_exceeded");


    /// <summary>
    /// Enum CompanyNameMaxLengthExceeded for value: company_name_max_length_exceeded
    /// </summary>
    public static AddressValidationDetailCode CompanyNameMaxLengthExceeded { get; } = new("company_name_max_length_exceeded");


    /// <summary>
    /// Enum Line1MinMaxLength for value: line1_min_max_length
    /// </summary>
    public static AddressValidationDetailCode Line1MinMaxLength { get; } = new("line1_min_max_length");


    /// <summary>
    /// Enum Line2MaxLengthExceeded for value: line2_max_length_exceeded
    /// </summary>
    public static AddressValidationDetailCode Line2MaxLengthExceeded { get; } = new("line2_max_length_exceeded");


    /// <summary>
    /// Enum Line3MaxLengthExceeded for value: line3_max_length_exceeded
    /// </summary>
    public static AddressValidationDetailCode Line3MaxLengthExceeded { get; } = new("line3_max_length_exceeded");


    /// <summary>
    /// Enum CityLocalityMaxLengthExceeded for value: city_locality_max_length_exceeded
    /// </summary>
    public static AddressValidationDetailCode CityLocalityMaxLengthExceeded { get; } = new("city_locality_max_length_exceeded");


    /// <summary>
    /// Enum StateProvinceMaxLengthExceeded for value: state_province_max_length_exceeded
    /// </summary>
    public static AddressValidationDetailCode StateProvinceMaxLengthExceeded { get; } = new("state_province_max_length_exceeded");


    /// <summary>
    /// Enum InvalidPostalCode for value: invalid_postal_code
    /// </summary>
    public static AddressValidationDetailCode InvalidPostalCode { get; } = new("invalid_postal_code");


    /// <summary>
    /// Enum CountryInvalidLength for value: country_invalid_length
    /// </summary>
    public static AddressValidationDetailCode CountryInvalidLength { get; } = new("country_invalid_length");


    /// <summary>
    /// Enum AddressNotFound for value: address_not_found
    /// </summary>
    public static AddressValidationDetailCode AddressNotFound { get; } = new("address_not_found");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;
}

internal class AddressValidationDetailCodeJsonConverter : JsonConverter<AddressValidationDetailCode>
{
    public override AddressValidationDetailCode? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new AddressValidationDetailCode(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, AddressValidationDetailCode value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(AddressValidationDetailCode);
}