namespace Shapes.Common.Exceptions;

public class ShapesException : Exception
{
    public ShapesException(string? message)
        : base(message) { }
}