

namespace GeometricFigures.Backend;

public class Rhombus : Square

{
    //fields

    private double _d1;
    private double _d2;

    // constructors 

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        D1 = d1;
        D2 = d2;
    }

    // properties

    public double D1 
    { get => _d1; 
        set => _d1 = ValidateD1(value); 
    }
    public double D2 
    { get => _d2; 
        set => _d2 = ValidateD2(value); }

    //public methods

    public override double GetArea()
    {
        return (_d1 * _d2) / 2;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    //private methods

    private double ValidateD1(double D1)
    {

        if (D1 <= 0)
        {
            throw new Exception($"Side  {D1} must be greater than zero ");
        }
        return D1;
    }
    private double ValidateD2(double D2)
    {
        if (D2 <= 0)
        {
            throw new Exception($"Side  {D2} must be greater than zero ");
        }
        return D2;
    }

}