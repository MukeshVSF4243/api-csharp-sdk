/* 
 * BoldSign API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

namespace BoldSign.Model
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    ///     Represents FontFamily.
    /// </summary>
    /// <value>Represents FieldType.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FontFamily
    {
        /// <summary>
        ///     Enum Helvetica for value: Helvetica
        /// </summary>
        [EnumMember(Value = "Helvetica")]
        Helvetica = 1,

        /// <summary>
        ///     Enum Courier for value: Courier
        /// </summary>
        [EnumMember(Value = "Courier")]
        Courier = 2,

        /// <summary>
        ///     Enum TimesRoman for value: Times new roman
        /// </summary>
        [EnumMember(Value = "TimesRoman")]
        TimesRoman = 3,
    }
}
