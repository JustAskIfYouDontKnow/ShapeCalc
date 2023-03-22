using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.ShapeServices.CircleService;

public interface ICircleService
{
    Task<double> GetArea(Circle circle);
    
    Task<double> GetPerimeter(Circle circle);
}