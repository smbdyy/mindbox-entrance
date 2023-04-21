using Shapes.Common.Exceptions;

namespace Shapes.Shapes;

public abstract class ShapeBase
{
    public const double ComparisonTolerance = 0.0001;
    public abstract double CalculateArea();

    protected static double ValidateLengthPositive(double length)
    {
        if (length <= 0)
        {
            throw IncorrectArgumentException.IncorrectLength(length);
        }

        return length;
    }
}