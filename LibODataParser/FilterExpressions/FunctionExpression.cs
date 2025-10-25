namespace LibODataParser.FilterExpressions;

/// <summary>
/// Represents a function call (e.g., contains, startswith, endswith)
/// </summary>
public class FunctionExpression : FilterExpression
{
    public string FunctionName { get; set; }
    public List<FilterExpression> Arguments { get; set; }

    public FunctionExpression(string functionName, List<FilterExpression> arguments)
        : base(nameof(FunctionExpression))
    {
        FunctionName = functionName;
        Arguments = arguments ?? new List<FilterExpression>();
    }

    public override string ToString()
    {
        return $"{FunctionName}({string.Join(", ", Arguments)})";
    }
}