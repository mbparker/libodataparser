namespace LibODataParser.FilterExpressions;

/// <summary>
/// Base class for all filter expressions
/// </summary>
public abstract class FilterExpression
{
    protected FilterExpression(string typeName)
    {
        TypeName = typeName;
    }
    public string TypeName { get; set; }

    public bool Is<T>() where T : FilterExpression
    {
        return this is T;
    }
    
    public T As<T>() where T : FilterExpression
    {
        return this as T;
    }
}