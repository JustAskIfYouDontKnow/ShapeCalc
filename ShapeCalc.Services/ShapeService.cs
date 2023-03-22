using ShapeCalc.Database.Models;
using ShapeCalc.Services.ShapeServices.CircleService;
using ShapeCalc.Services.ShapeServices.SquareService;
using ShapeCalc.Services.ShapeServices.TriangleService;

namespace ShapeCalc.Services;

public class ShapeService : IShapeService
{
    private readonly ITriangleService _triangleService;
    private readonly ICircleService _circleService;
    private readonly ISquareService _squareService;
    
    public ShapeService(ITriangleService triangleService, ICircleService circleService, ISquareService squareService)
    {
        _triangleService = triangleService;
        _circleService = circleService;
        _squareService = squareService;
    }
    
    public async Task<double> GetArea(IShape shape)
    {
        return shape switch
        {
            Triangle triangle => await _triangleService.GetArea(triangle),
            Circle circle     => await _circleService.GetArea(circle),
            Square square     => await _squareService.GetArea(square),
            _                 => throw new ArgumentException("Unsupported shape type")
        };
    }

    public async Task<bool> IsRightAngle(IShape shape)
    {
        return shape switch
        {
            Triangle triangle => await _triangleService.IsRightAngle(triangle),
            Square square     => await _squareService.IsRightAngle(square),
            _                 => throw new ArgumentException("Unsupported shape type")
        };
    }


    public async Task<double> GetPerimeter(IShape shape)
    {
        return shape switch
        {
            Triangle triangle => await _triangleService.GetPerimeter(triangle),
            Circle circle => await _circleService.GetPerimeter(circle),
            Square square => await _squareService.GetPerimeter(square),
            _ => throw new ArgumentException("Unsupported shape type")
        };
    }
}