namespace ShapeCalc.Database.Models;

public class PolygonPoints : IShape
{
    public List<double> X { get; set; }

    public List<double> Y { get; set; }

}