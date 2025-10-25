using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LibODataParser.Sorting;

/// <summary>
/// Order direction enumeration
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OrderDirection
{
    Ascending,
    Descending
}