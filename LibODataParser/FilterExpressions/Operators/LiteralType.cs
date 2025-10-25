using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LibODataParser.FilterExpressions.Operators;

/// <summary>
/// Literal value types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum LiteralType
{
    String,
    Number,
    Boolean,
    Null,
    DateTime,
    Guid
}