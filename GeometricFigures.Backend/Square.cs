

namespace GeometricFigures.Backend;
public class Square : GeometricFigure
{
    //fields

    private double _a;

    //constructors

    public Square(string name, double a) 
    {
        A = a;
        this.name = name;
    }

    //properties

    public double A
    {
        get => _a;
        set => _a = ValidateA(value);
    }

    // public methods

    public override double GetArea()
    {
        return _a * _a;
    }

    public override double GetPerimeter()
    {
        return 4 * _a;
    }

    // private methods
    private double ValidateA(double A)
    {
        if (A <= 0)
        {
            throw new Exception($"Side  {A} must be greater than zero ");
        }
        return A;
    }
}