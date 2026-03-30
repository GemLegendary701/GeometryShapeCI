using GeometryApp;
using System;

namespace GeometryAppTests;

public class RectangleTests
{
    [Fact]
    public void Constructor_ValidDimensions_CreatesRectangle()
    {
        var rect = new Rectangle(5, 10);
        Assert.Equal(5, rect.Width);
        Assert.Equal(10, rect.Height);
    }

    [Theory]
    [InlineData(2, 3, 6, 10)]
    [InlineData(4, 5, 20, 18)]
    [InlineData(1.5, 2.5, 3.75, 8)]
    public void AreaAndPerimeter_ValidData_ReturnsCorrectValues(double width, double height, double expectedArea, double expectedPerimeter)
    {
        var rect = new Rectangle(width, height);
        Assert.Equal(expectedArea, rect.Area());
        Assert.Equal(expectedPerimeter, rect.Perimeter());
    }

    [Fact]
    public void Constructor_NegativeWidth_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(-5, 10));
    }

    [Fact]
    public void Constructor_NegativeHeight_ThrowsArgumentOutOfRangeException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Rectangle(5, -10));
    }
}