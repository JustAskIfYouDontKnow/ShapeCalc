using ShapeCalc.Database.Models;

namespace ShapeCalc.Services;

public interface IShapeService
{
    Task<double> GetArea(IShape shape);
    Task<bool> IsRightAngle(IShape shape);
    Task<double> GetPerimeter(IShape shape);
}