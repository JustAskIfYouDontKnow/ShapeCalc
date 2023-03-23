using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.ShapeServices;

public interface IShapeService<in T> where T : IShape
{
    Task<double> GetArea(T shape);
    Task<double> GetPerimeter(T shape);
    Task<bool> IsRightAngle(T shape);
}
