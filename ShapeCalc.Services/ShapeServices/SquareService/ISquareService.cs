using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.ShapeServices.SquareService;

public interface ISquareService
{
    Task<double> GetArea(Square square);
    Task<double> GetPerimeter(Square square);
    Task<bool> IsRightAngle(Square square);
    
}