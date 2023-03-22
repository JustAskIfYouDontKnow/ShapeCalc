using ShapeCalc.Services.ShapeServices.CircleService;
using ShapeCalc.Services.ShapeServices.SquareService;
using ShapeCalc.Services.ShapeServices.TriangleService;

namespace ShapeCalc.Services;

public static class ShapeServiceFactory 
{
    public static ShapeService Create()
    {
        var triangleService = new TriangleService();
        var circleService = new CircleService();
        var squareService = new SquareService();
        
        return new ShapeService(triangleService, circleService, squareService);
    }
}