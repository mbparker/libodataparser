using LibODataParser.FilterExpressions.Operators;

namespace LibODataParser.FilterExpressions;

/// <summary>
/// Represents a binary operation (e.g., eq, ne, gt, lt, and, or)
/// </summary>
public class FilterBinaryExpression : FilterExpression
{
    public FilterExpression Left { get; set; }
    public BinaryOperator Operator { get; set; }
    public FilterExpression Right { get; set; }

    public FilterBinaryExpression(FilterExpression left, BinaryOperator op, FilterExpression right)
        : base(nameof(FilterBinaryExpression))
    {
        Left = left;
        Operator = op;
        Right = right;
    }

    public override string ToString()
    {
        return $"({Left} {Operator.ToODataString()} {Right})";
    }
}