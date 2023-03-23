using ShapeCalc.Services.ShapeServices.CircleService;
using ShapeCalc.Services.ShapeServices.PolygonService;
using ShapeCalc.Services.ShapeServices.SquareService;
using ShapeCalc.Services.ShapeServices.TriangleService;

namespace ShapeCalc.Services;

public class ServiceContainer : IServiceContainer
{
    public ICircleService CircleService { get; }

    public ISquareService SquareService { get; }

    public ITriangleService TriangleService { get; }

    public IPolygonService PolygonService { get; set; }


    public ServiceContainer()
    {
        CircleService = new CircleService();
        SquareService = new SquareService();
        TriangleService = new TriangleService();
        PolygonService = new PolygonService();
    }

}