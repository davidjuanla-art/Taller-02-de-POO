namespace GeometricFigures.Backend;


public abstract class GeometricFigure
{

   
    
    //properties
    public String name { get; set; } = null!;



    //method

    public abstract double GetArea();

    public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{name}\t        => Area.....: {GetArea():f5}\t Perimeter:    {GetPerimeter():f5}";
    }
}