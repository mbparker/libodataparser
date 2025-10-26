using LibODataParser.FilterExpressions.Operators;

namespace LibODataParser.FilterExpressions;

/// <summary>
/// Represents a literal value (string, number, boolean, null)
/// </summary>
public class FilterLiteralExpression : FilterExpression
{
    public object Value { get; set; }
    public LiteralType Type { get; set; }

    public FilterLiteralExpression(object value, LiteralType type)
        : base(nameof(FilterLiteralExpression))
    {
        Value = value;
        Type = type;
    }

    public override string ToString()
    {
        if (Value == null) return "null";
            
        switch (Type)
        {
            case LiteralType.String:
                return $"'{Value}'";
            case LiteralType.Boolean:
                return Value.ToString().ToLower();
            default:
                return Value.ToString();
        }
    }
}