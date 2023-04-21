namespace Shapes.Shapes;

public class Circle : ShapeBase
{
    public Circle(double radius)
    {
        Radius = ValidateLengthPositive(radius);
    }

    public double Radius { get; }

    public override double CalculateArea()
    {
        return Radius * Radius * Math.PI;
    }
}