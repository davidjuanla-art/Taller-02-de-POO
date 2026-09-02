

namespace GeometricFigures.Backend;

    public class Rectangle : Square
    {
        // fields
        private double _b;

    //constructors

    public Rectangle(string name, double a, double b) : base(name, a)
    {
        B = b;
    }

    //properties

    public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

    //public methods
    public override double GetArea()
        {
            return A * B;
        }

        public override double GetPerimeter()
        {
            return 2* (A + B);
        }

    // private methods

    private double ValidateB(double B)
    {
        if (B <= 0)
            throw new Exception($"Side {B} must be greater than zero");
        return B;
    }


}

