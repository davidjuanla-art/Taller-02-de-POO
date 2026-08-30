namespace GeometricFigures.Backend;

public class Kite : Rhombus
{
    private double _b;

    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
    {
        B = b;
    }

    public double B
    {
        get => _b;
        set => _b = ValidateB(value);
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private double ValidateB(double B)
    {
        if (B <= 0)
            throw new Exception($"Side {B} must be greater than zero");
        return B;
    }
}
