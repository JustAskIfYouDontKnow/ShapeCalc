using ShapeCalc.Services.ShapeServices.CircleService;
using ShapeCalc.Services.ShapeServices.PolygonService;
using ShapeCalc.Services.ShapeServices.SquareService;
using ShapeCalc.Services.ShapeServices.TriangleService;

namespace ShapeCalc.Services;

public interface IServiceContainer
{
    ICircleService CircleService { get; }
    
    ISquareService SquareService { get; }
    
    ITriangleService TriangleService { get; }
    
    IPolygonService PolygonService { get; }
}