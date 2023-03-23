using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.ShapeServices.PolygonService;

public class PolygonService : IPolygonService
{

    public Task<double> GetArea(PolygonPoints shape)
    {
        double area = 0;

        for (var i = 0; i < shape.X.Count - 1; i++)
        {
            var x1 = shape.X[i];
            var y1 = shape.Y[i];

            var x2 = shape.X[i + 1];
            var y2 = shape.Y[i + 1];

            area += (x1 * y2) - (x2 * y1);
        }

        area += (shape.X.Last() * shape.Y.First()) - (shape.X.First() * shape.Y.Last());

        area = Math.Abs(area / 2);

        return Task.FromResult(area);
    }


    public Task<double> GetPerimeter(PolygonPoints shape)
    {
        throw new NotImplementedException();
    }


    public Task<bool> IsRightAngle(PolygonPoints shape)
    {
        throw new NotImplementedException();
    }
}