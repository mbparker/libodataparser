using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LibODataParser.FilterExpressions.Operators;

/// <summary>
/// Unary operators supported in OData filters
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum UnaryOperator
{
    Not,    // not
    Negate  // -
}