

namespace GeometricFigures.Backend;

public class Trapeze : Triangle
{
    //fields

    private double _d;

    //constructors
    public Trapeze(string name, double a, double b, double c, double h, double d) : base(name, a, b, c, h)
    {
        D = d;
    }

    public double D 
    {
        get => _d;
        set => _d = ValidateD(value); 
    }

    public override double GetArea()
    {
        return (B + D) * (H/2);
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }

    //private methods

    private double ValidateD(double D)
    {
        if (D <= 0)
            throw new Exception($"Side {D} must be greater than zero");
        return D;
    }
}

