

namespace GeometricFigures.Backend;

    public class Triangle : Rectangle
{
    //fields

    private double _c;
    private double _h;

    //constructors
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        C = c;
        H = h;
    }

    //properties 

    public double C 
    { 
        get => _c;
        set => _c = ValidateC(value); 
    }
    public double H 
    { 
        get => _h; 
        set => _h = ValidateH(value); }

    // public methods
    public override double GetArea()
    {
        return (B * H)/2;
    }

    public override double GetPerimeter()
    {
        return A + B + C;
    }

    //private methods
    private double ValidateC(double C)
    {
        if (C <= 0)
            throw new Exception($"Side {C} must be greater than zero");
        return C;
    }

    private double ValidateH(double H)
    {
        if (H <= 0)
            throw new Exception($"Side {H} must be greater than zero");
        return H;
    }


}

