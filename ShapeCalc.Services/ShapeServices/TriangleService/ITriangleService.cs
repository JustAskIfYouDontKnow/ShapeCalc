using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.ShapeServices.TriangleService;

public interface ITriangleService
{
    Task<double> GetArea(Triangle triangle);
    Task<double> GetPerimeter(Triangle triangle);
    Task<bool> IsRightAngle(Triangle triangle);
}