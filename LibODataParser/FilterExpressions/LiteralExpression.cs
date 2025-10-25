using LibODataParser.FilterExpressions.Operators;

namespace LibODataParser.FilterExpressions;

/// <summary>
/// Represents a literal value (string, number, boolean, null)
/// </summary>
public class LiteralExpression : FilterExpression
{
    public object Value { get; set; }
    public LiteralType Type { get; set; }

    public LiteralExpression(object value, LiteralType type)
        : base(nameof(LiteralExpression))
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