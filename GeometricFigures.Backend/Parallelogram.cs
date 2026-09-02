

namespace GeometricFigures.Backend;

    public class Parallelogram: Rectangle
    {
    // fields.
    private double _h;

    //constructors

    public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        H = h;
    }

    //propiertes 
    public double H { get => _h;
        set => _h = ValidateH(value); }

    //public methods

    public override double GetArea()
    {
        return B * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }


    // private methods

    private double ValidateH(double H)
    {
        if (H <= 0)
            throw new Exception($"Side {H} must be greater than zero");
        return H;
    }

}

