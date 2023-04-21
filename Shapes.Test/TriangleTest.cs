using System.Collections.Generic;
using Shapes.Common.Exceptions;
using Shapes.Shapes;
using Xunit;

namespace Shapes.Test;

public class TriangleTest
{
    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(3.01, 4.095, 7.2)]
    [InlineData(7, 1, 1)]
    public void ShouldThrowIfTriangleInequalityViolated(double sideA, double sideB, double sideC)
    {
        Assert.Throws<IncorrectArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(0, 1, 2)]
    [InlineData(1, -2, 3)]
    [InlineData(1, 2, -3)]
    public void ShouldThrowIfLengthIsNotPositive(double sideA, double sideB, double sideC)
    {
        Assert.Throws<IncorrectArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Theory]
    [MemberData(nameof(TriangleIsRightAngledData))]
    public void ShouldDetermineIfTriangleIsRightAngled(Triangle triangle, bool isRightAngled)
    {
        Assert.Equal(isRightAngled, triangle.IsRightAngled());
    }

    public static IEnumerable<object[]> TriangleIsRightAngledData()
    {
        yield return new object[] { new Triangle(3, 4, 5), true };
        yield return new object[] { new Triangle(3, 4, 5.1), false };
        yield return new object[] { new Triangle(15, 9, 12), true };
    }
}