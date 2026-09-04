namespace GeometricFigures.Backend;


public abstract class GeometricFigure
{
    protected GeometricFigure(string name)
    {
        this.name = name;
    }



    //properties
    public String name { get; set; } = null!;

    //constructor





    //method

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{name,-15} => Área.....: {GetArea(),12:n5}      Perímetro: {GetPerimeter(),12:n5}";
    }


}