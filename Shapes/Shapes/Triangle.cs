using Shapes.Common.Exceptions;

namespace Shapes.Shapes;

public class Triangle : ShapeBase
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = ValidateLengthPositive(sideA);
        SideB = ValidateLengthPositive(sideB);
        SideC = ValidateLengthPositive(sideC);
        ValidateTriangleInequality();
    }

    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public override double CalculateArea()
    {
        // Здесь реализована формула Герона
        double p = (SideA + SideB + SideC) / 2;
        double areaSquared = p * (p - SideA) * (p - SideB) * (p - SideC);
        return Math.Sqrt(areaSquared);
    }

    public bool IsRightAngled()
    {
        // Для проверки используем теорему Пифагора
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        double aSquared = sides[0] * sides[0];
        double bSquared = sides[1] * sides[1];
        double cSquared = sides[2] * sides[2];
        return Math.Abs(aSquared + bSquared - cSquared) < ComparisonTolerance;
    }

    private void ValidateTriangleInequality()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        if (sides[0] + sides[1] <= sides[2])
        {
            throw IncorrectArgumentException.TriangleInequality(SideA, SideB, SideC);
        }
    }
}