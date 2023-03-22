using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.Services;

public interface ICircleService
{
    Task<double> GetArea(Circle circle);
}