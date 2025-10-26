using LibODataParser.FilterExpressions.Operators;

namespace LibODataParser.FilterExpressions;

/// <summary>
/// Represents a unary operation (e.g., not)
/// </summary>
public class FilterUnaryExpression : FilterExpression
{
    public UnaryOperator Operator { get; set; }
    public FilterExpression Operand { get; set; }

    public FilterUnaryExpression(UnaryOperator op, FilterExpression operand)
        : base(nameof(FilterUnaryExpression))
    {
        Operator = op;
        Operand = operand;
    }

    public override string ToString()
    {
        return $"{Operator.ToODataString()} ({Operand})";
    }
}