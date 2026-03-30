using GeometryApp;
using System;

namespace GeometryAppTests;

public class TriangleTests
{
    [Fact]
    public void Constructor_ValidSides_CreatesTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(3, triangle.SideA);
        Assert.Equal(4, triangle.SideB);
        Assert.Equal(5, triangle.SideC);
    }

    [Theory]
    [InlineData(3, 4, 5, 6, 12)]
    [InlineData(5, 12, 13, 30, 30)]
    [InlineData(8, 15, 17, 60, 40)]
    public void AreaAndPerimeter_ValidTriangle_ReturnsCorrectValues(double a, double b, double c, double expectedArea, double expectedPerimeter)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Equal(expectedArea, triangle.Area(), 2);
        Assert.Equal(expectedPerimeter, triangle.Perimeter());
    }

    [Fact]
    public void Constructor_NegativeSide_ThrowsArgumentOutOfRangeException()  // ← исправлено
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3, 4, 5));
    }

    [Fact]
    public void Constructor_InvalidTriangle_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
    }
    [Fact]
    public void Test_That_Will_Fail()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.Equal(100, triangle.Area());
    }
}