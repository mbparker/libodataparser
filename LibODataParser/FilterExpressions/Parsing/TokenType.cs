namespace LibODataParser.FilterExpressions.Parsing;

internal enum TokenType
{
    Property,
    String,
    Number,
    DateTime,
    Boolean,
    Null,
    Operator,
    Function,
    OpenParen,
    CloseParen,
    Comma,
    End
}