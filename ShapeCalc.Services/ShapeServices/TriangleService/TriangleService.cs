using ShapeCalc.Database.Models;

namespace ShapeCalc.Services.ShapeServices.TriangleService;

public class TriangleService : ITriangleService
{
    public Task<double> GetArea(Triangle triangle)
    {
        var a = triangle.SideA;
        var b = triangle.SideB;
        var c = triangle.SideC;

        var s = (a + b + c) / 2;
        var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    
        area = Double.IsNaN(area) ? 0 : area;

        return Task.FromResult(area);
    }


    public Task<double> GetPerimeter(Triangle triangle)
    {
        var perimeter = triangle.SideA + triangle.SideB + triangle.SideC;

        return Task.FromResult(perimeter);
    }


    public Task<bool> IsRightAngle(Triangle triangle)
    {
        const double tolerance = 0.0001;

        var a = triangle.SideA;
        var b = triangle.SideB;
        var c = triangle.SideC;

        var angleA = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI;
        var angleB = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI;
        var angleC = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI;

        return Task.FromResult(Math.Abs(angleA - 90) < tolerance || Math.Abs(angleB - 90) < tolerance || Math.Abs(angleC - 90) < tolerance);
    }
}