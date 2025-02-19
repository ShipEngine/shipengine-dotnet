// <auto-generated />
// DO NOT MODIFY THIS FILE

// Changes can be made in a corresponding partial file, or by changing
// the template in <root>/generation/templates and generating the class again.


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
/// The possible smart post hub values
/// </summary>
/// <value>The possible smart post hub values</value>
[JsonConverter(typeof(SmartPostHubJsonConverter))]
public class SmartPostHub
{
    private readonly string _value;

    /// <summary>
    /// Create a new instance of SmartPostHub with a predefined value.
    /// </summary>
    internal SmartPostHub()
    {
        _value = "none";
    }

    /// <summary>
    /// Create a new instance of SmartPostHub with a custom value.
    /// </summary>
    /// <param name="value">The value of the SmartPostHub</param>
    /// <remarks>
    /// You can send a custom value to the API using this constructor, but the API most likely won't know what to do with it.
    /// You should use the predefined values returned by the static properties of this class unless you know that the value is value.
    /// </remarks>
    public SmartPostHub(string value)
    {
        _value = value;
    }

    /// <summary>
    /// Enum None for value: none
    /// </summary>
    public static SmartPostHub None { get; } = new("none");


    /// <summary>
    /// Enum AllentownPa for value: allentown_pa
    /// </summary>
    public static SmartPostHub AllentownPa { get; } = new("allentown_pa");


    /// <summary>
    /// Enum AtlantaGa for value: atlanta_ga
    /// </summary>
    public static SmartPostHub AtlantaGa { get; } = new("atlanta_ga");


    /// <summary>
    /// Enum BaltimoreMd for value: baltimore_md
    /// </summary>
    public static SmartPostHub BaltimoreMd { get; } = new("baltimore_md");


    /// <summary>
    /// Enum CharlotteNc for value: charlotte_nc
    /// </summary>
    public static SmartPostHub CharlotteNc { get; } = new("charlotte_nc");


    /// <summary>
    /// Enum ChinoCa for value: chino_ca
    /// </summary>
    public static SmartPostHub ChinoCa { get; } = new("chino_ca");


    /// <summary>
    /// Enum DallasTx for value: dallas_tx
    /// </summary>
    public static SmartPostHub DallasTx { get; } = new("dallas_tx");


    /// <summary>
    /// Enum DenverCo for value: denver_co
    /// </summary>
    public static SmartPostHub DenverCo { get; } = new("denver_co");


    /// <summary>
    /// Enum DetroitMi for value: detroit_mi
    /// </summary>
    public static SmartPostHub DetroitMi { get; } = new("detroit_mi");


    /// <summary>
    /// Enum EdisonNj for value: edison_nj
    /// </summary>
    public static SmartPostHub EdisonNj { get; } = new("edison_nj");


    /// <summary>
    /// Enum GroveCityOh for value: grove_city_oh
    /// </summary>
    public static SmartPostHub GroveCityOh { get; } = new("grove_city_oh");


    /// <summary>
    /// Enum GroveportOh for value: groveport_oh
    /// </summary>
    public static SmartPostHub GroveportOh { get; } = new("groveport_oh");


    /// <summary>
    /// Enum HoustonTx for value: houston_tx
    /// </summary>
    public static SmartPostHub HoustonTx { get; } = new("houston_tx");


    /// <summary>
    /// Enum IndianapolisIn for value: indianapolis_in
    /// </summary>
    public static SmartPostHub IndianapolisIn { get; } = new("indianapolis_in");


    /// <summary>
    /// Enum KansasCityKs for value: kansas_city_ks
    /// </summary>
    public static SmartPostHub KansasCityKs { get; } = new("kansas_city_ks");


    /// <summary>
    /// Enum LosAngelesCa for value: los_angeles_ca
    /// </summary>
    public static SmartPostHub LosAngelesCa { get; } = new("los_angeles_ca");


    /// <summary>
    /// Enum MartinsburgWv for value: martinsburg_wv
    /// </summary>
    public static SmartPostHub MartinsburgWv { get; } = new("martinsburg_wv");


    /// <summary>
    /// Enum MemphisTn for value: memphis_tn
    /// </summary>
    public static SmartPostHub MemphisTn { get; } = new("memphis_tn");


    /// <summary>
    /// Enum MinneapolisMn for value: minneapolis_mn
    /// </summary>
    public static SmartPostHub MinneapolisMn { get; } = new("minneapolis_mn");


    /// <summary>
    /// Enum NewBerlinWi for value: new_berlin_wi
    /// </summary>
    public static SmartPostHub NewBerlinWi { get; } = new("new_berlin_wi");


    /// <summary>
    /// Enum NorthboroughMa for value: northborough_ma
    /// </summary>
    public static SmartPostHub NorthboroughMa { get; } = new("northborough_ma");


    /// <summary>
    /// Enum OrlandoFl for value: orlando_fl
    /// </summary>
    public static SmartPostHub OrlandoFl { get; } = new("orlando_fl");


    /// <summary>
    /// Enum PhoneixAz for value: phoneix_az
    /// </summary>
    public static SmartPostHub PhoneixAz { get; } = new("phoneix_az");


    /// <summary>
    /// Enum PittsburghPa for value: pittsburgh_pa
    /// </summary>
    public static SmartPostHub PittsburghPa { get; } = new("pittsburgh_pa");


    /// <summary>
    /// Enum RenoNv for value: reno_nv
    /// </summary>
    public static SmartPostHub RenoNv { get; } = new("reno_nv");


    /// <summary>
    /// Enum SacramentoCa for value: sacramento_ca
    /// </summary>
    public static SmartPostHub SacramentoCa { get; } = new("sacramento_ca");


    /// <summary>
    /// Enum SaltLakeCityUt for value: salt_lake_city_ut
    /// </summary>
    public static SmartPostHub SaltLakeCityUt { get; } = new("salt_lake_city_ut");


    /// <summary>
    /// Enum SeattleWa for value: seattle_wa
    /// </summary>
    public static SmartPostHub SeattleWa { get; } = new("seattle_wa");


    /// <summary>
    /// Enum StLouisMo for value: st_louis_mo
    /// </summary>
    public static SmartPostHub StLouisMo { get; } = new("st_louis_mo");


    /// <summary>
    /// Enum WindsorCt for value: windsor_ct
    /// </summary>
    public static SmartPostHub WindsorCt { get; } = new("windsor_ct");


    /// <summary>
    /// Enum NewarkNy for value: newark_ny
    /// </summary>
    public static SmartPostHub NewarkNy { get; } = new("newark_ny");


    /// <summary>
    /// Enum SouthBrunswickNj for value: south_brunswick_nj
    /// </summary>
    public static SmartPostHub SouthBrunswickNj { get; } = new("south_brunswick_nj");


    /// <summary>
    /// Enum ScrantonPa for value: scranton_pa
    /// </summary>
    public static SmartPostHub ScrantonPa { get; } = new("scranton_pa");


    /// <summary>
    /// Enum WheelingIl for value: wheeling_il
    /// </summary>
    public static SmartPostHub WheelingIl { get; } = new("wheeling_il");


    /// <summary>
    /// Enum MiddletownCt for value: middletown_ct
    /// </summary>
    public static SmartPostHub MiddletownCt { get; } = new("middletown_ct");


    /// <summary>
    /// Enum PortlandOr for value: portland_or
    /// </summary>
    public static SmartPostHub PortlandOr { get; } = new("portland_or");


    /// <summary>
    /// Get a string representation of the current value
    /// </summary>
    public override string ToString() => _value;

    /// <summary>
    /// Get whether this instance is equal to another instance
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is SmartPostHub other && _value == other._value;

    /// <summary>
    /// Get the hash code of the object
    /// </summary>
    public override int GetHashCode() => _value.GetHashCode();
}

internal class SmartPostHubJsonConverter : JsonConverter<SmartPostHub>
{
    public override SmartPostHub? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        reader.TokenType == JsonTokenType.String ? new SmartPostHub(reader.GetString()!) : null;

    public override void Write(Utf8JsonWriter writer, SmartPostHub value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());

    public override bool CanConvert(Type typeToConvert) =>
        typeToConvert == typeof(SmartPostHub);
}