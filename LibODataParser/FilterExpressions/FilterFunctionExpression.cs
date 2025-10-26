namespace LibODataParser.FilterExpressions;

/// <summary>
/// Represents a function call (e.g., contains, startswith, endswith)
/// </summary>
public class FilterFunctionExpression : FilterExpression
{
    public string FunctionName { get; set; }
    public List<FilterExpression> Arguments { get; set; }

    public FilterFunctionExpression(string functionName, List<FilterExpression> arguments)
        : base(nameof(FilterFunctionExpression))
    {
        FunctionName = functionName;
        Arguments = arguments ?? new List<FilterExpression>();
    }

    public override string ToString()
    {
        return $"{FunctionName}({string.Join(", ", Arguments)})";
    }
}