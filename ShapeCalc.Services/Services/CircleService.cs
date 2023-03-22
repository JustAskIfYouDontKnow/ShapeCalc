using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.Services;

public class CircleService : ICircleService
{

    public async Task<double> GetArea(Circle shape)
    {
        var r = Math.PI * shape.Radius * shape.Radius;
        return r < 0 ? 0 : r;
    }

}