using LibODataParser.FilterExpressions.Operators;

namespace LibODataParser.FilterExpressions;

/// <summary>
/// Represents a unary operation (e.g., not)
/// </summary>
public class UnaryExpression : FilterExpression
{
    public UnaryOperator Operator { get; set; }
    public FilterExpression Operand { get; set; }

    public UnaryExpression(UnaryOperator op, FilterExpression operand)
        : base(nameof(UnaryExpression))
    {
        Operator = op;
        Operand = operand;
    }

    public override string ToString()
    {
        return $"{Operator.ToODataString()} ({Operand})";
    }
}