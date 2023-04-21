namespace Shapes.Common.Exceptions;

public class IncorrectArgumentException : ShapesException
{
    public IncorrectArgumentException(string? message)
        : base(message) { }

    public static IncorrectArgumentException IncorrectLength(double length)
    {
        return new IncorrectArgumentException($"length must be a positive number ({length} given)");
    }

    public static IncorrectArgumentException TriangleInequality(double a, double b, double c)
    {
        return new IncorrectArgumentException($"triangle inequality is not satisfied: {a} + {b} >= {c}");
    }
}