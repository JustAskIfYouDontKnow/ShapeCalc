using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.Services;

public interface ITriangleService
{
    Task<double> GetArea(Triangle triangle);
    Task<bool> IsRightAngle(Triangle triangle);
}