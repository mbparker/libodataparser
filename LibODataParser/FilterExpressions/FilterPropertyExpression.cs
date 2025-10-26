namespace LibODataParser.FilterExpressions;

/// <summary>
/// Represents a property/field reference
/// </summary>
public class FilterPropertyExpression : FilterExpression
{
    public string PropertyName { get; set; }

    public FilterPropertyExpression(string propertyName)
        : base(nameof(FilterPropertyExpression))
    {
        PropertyName = propertyName;
    }

    public override string ToString()
    {
        return PropertyName;
    }
}