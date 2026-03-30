using System;

namespace GeometryApp;

public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public double Width
    {
        get => _width;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(Width), "Ширина должна быть положительным числом");
            _width = value;
        }
    }

    public double Height
    {
        get => _height;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(Height), "Высота должна быть положительным числом");
            _height = value;
        }
    }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area() => Width * Height;

    public override double Perimeter() => 2 * (Width + Height);

    public override string ToString() => $"Прямоугольник: Ширина = {Width}, Высота = {Height}, Площадь = {Area()}, Периметр = {Perimeter()}";
}