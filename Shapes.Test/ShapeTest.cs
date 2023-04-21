using System;
using System.Collections.Generic;
using Shapes.Shapes;
using Xunit;

namespace Shapes.Test;

public class ShapeTest
{
    public const int ComparisonPrecision = 3;

    [Theory]
    [MemberData(nameof(ShapeAreaData))]
    public void ShouldCalculateAreaCorrectly(Shape shape, double expectedArea)
    {
        Assert.Equal(expectedArea, shape.CalculateArea(), ComparisonPrecision);
    }

    public static IEnumerable<object[]> ShapeAreaData()
    {
        yield return new object[] { new Triangle(6, 8, 10), 24 };
        yield return new object[] { new Triangle(15, 9, 12), 54 };
        yield return new object[] { new Triangle(0.6, 0.8, 1), 0.24 };
        yield return new object[] { new Circle(5), 25 * Math.PI };
        yield return new object[] { new Circle(1), Math.PI };
        yield return new object[] { new Circle(0.2), 0.04 * Math.PI };
    }
}