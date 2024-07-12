using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;

namespace ShipEngineSDK;

/// <summary>
/// Utility functions providing some benefit to API client consumers.
/// </summary>
internal static class ClientUtils
{
    private const string DateTimeFormat = "o";

    /// <summary>
    /// Convert params to key/value pairs.
    /// Use collectionFormat to properly format lists and collections.
    /// </summary>
    /// <param name="collectionFormat">The swagger-supported collection format, one of: csv, tsv, ssv, pipes, multi</param>
    /// <param name="name">Key name.</param>
    /// <param name="value">Value object.</param>
    /// <returns>A multimap of keys with 1..n associated values.</returns>
    public static Multimap<string, string> ParameterToMultiMap(string collectionFormat, string name, object value)
    {
        var parameters = new Multimap<string, string>();

        switch (value)
        {
            case ICollection collection when collectionFormat == "multi":
                {
                    foreach (var item in collection)
                    {
                        parameters.Add(name, ParameterToString(item));
                    }

                    break;
                }
            case IDictionary dictionary when collectionFormat == "deepObject":
                {
                    foreach (DictionaryEntry entry in dictionary)
                    {
                        parameters.Add(name + "[" + entry.Key + "]", ParameterToString(entry.Value));
                    }

                    break;
                }
            case IDictionary dictionary:
                {
                    foreach (DictionaryEntry entry in dictionary)
                    {
                        parameters.Add(entry.Key.ToString(), ParameterToString(entry.Value));
                    }

                    break;
                }
            default:
                parameters.Add(name, ParameterToString(value));
                break;
        }

        return parameters;
    }

    /// <summary>
    /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
    /// If parameter is a list, join the list with ",".
    /// Otherwise just return the string.
    /// </summary>
    /// <param name="obj">The parameter (header, path, query, form).</param>
    /// <returns>Formatted string.</returns>
    public static string ParameterToString(object obj)
    {
        return obj switch
        {
            // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
            // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
            // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
            // For example: 2009-06-15T13:45:30.0000000
            DateTime dateTime => dateTime.ToString(DateTimeFormat),
            // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
            // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
            // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
            // For example: 2009-06-15T13:45:30.0000000
            DateTimeOffset dateTimeOffset => dateTimeOffset.ToString(DateTimeFormat),
            bool boolean => boolean ? "true" : "false",
            ICollection collection => string.Join(",", collection.OfType<object>().Select(ParameterToString)),
            Enum when HasEnumMemberAttrValue(obj) => GetEnumMemberAttrValue(obj),
            _ => Convert.ToString(obj, CultureInfo.InvariantCulture)
        };
    }

    /// <summary>
    /// Is the Enum decorated with EnumMember Attribute
    /// </summary>
    /// <param name="enumVal"></param>
    /// <returns>true if found</returns>
    private static bool HasEnumMemberAttrValue(object enumVal)
    {
        if (enumVal == null)
            throw new ArgumentNullException(nameof(enumVal));
        var enumType = enumVal.GetType();
        var memInfo = enumType.GetMember(enumVal.ToString() ?? throw new InvalidOperationException());
        var attr = memInfo.FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault();

        return attr != null;
    }

    /// <summary>
    /// Get the EnumMember value
    /// </summary>
    /// <param name="enumVal"></param>
    /// <returns>EnumMember value as string otherwise null</returns>
    private static string GetEnumMemberAttrValue(object enumVal)
    {
        if (enumVal == null)
            throw new ArgumentNullException(nameof(enumVal));
        var enumType = enumVal.GetType();
        var memInfo = enumType.GetMember(enumVal.ToString() ?? throw new InvalidOperationException());
        var attr = memInfo.FirstOrDefault()?.GetCustomAttributes(false).OfType<EnumMemberAttribute>().FirstOrDefault();
        if (attr != null)
        {
            return attr.Value;
        }
        return null;
    }
}