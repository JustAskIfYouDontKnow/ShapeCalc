using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.ShapeServices.CircleService;

public class CircleService : ICircleService
{
    
    public Task<double> GetArea(Circle shape)
    {
        return Task.FromResult(Math.PI * shape.Radius * shape.Radius);
    }


    public Task<double> GetPerimeter(Circle circle)
    {
        var perimeter = 2 * Math.PI * circle.Radius;

        return Task.FromResult(perimeter);
    }

}