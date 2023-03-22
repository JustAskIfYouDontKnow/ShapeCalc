using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.ShapeServices.SquareService;

public class SquareService : ISquareService
{

    public Task<double> GetArea(Square square)
    {
        var area = square.Side * square.Side;

        return Task.FromResult(area);
    }


    public Task<double> GetPerimeter(Square square)
    {
        var perimeter = 4 * square.Side;

        return Task.FromResult(perimeter);
    }


    public Task<bool> IsRightAngle(Square square)
    {
        return Task.FromResult(true);
    }

}