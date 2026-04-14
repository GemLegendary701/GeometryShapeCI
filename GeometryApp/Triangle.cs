using System;

namespace GeometryApp;

public class Triangle : Shape
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public double SideA
    {
        get => _sideA;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(SideA), "Сторона A должна быть положительным числом.");
            _sideA = value;
        }
    }

    public double SideB
    {
        get => _sideB;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(SideB), "Сторона B должна быть положительным числом.");
            _sideB = value;
        }
    }

    public double SideC
    {
        get => _sideC;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(SideC), "Сторона C должна быть положительным числом.");
            _sideC = value;
        }
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            throw new ArgumentException("Треугольник с такими сторонами не существует.");
    }

    public override double Area()
    {
        double p = Perimeter() / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public override double Perimeter() => SideA + SideB + SideC;

    public override string ToString() => $"Треугольник: Стороны = {SideA},{SideB},{SideC}, Площадь = {Area():F2}, Периметр = {Perimeter()}";
}