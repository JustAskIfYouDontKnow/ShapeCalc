using ShapeCalc.Database.Models;
using ShapeCalc.Services.ShapeServices.CircleService;
using Xunit;

namespace ShapeCalc.Test
{
    public class CircleServiceTests
    {
        private readonly ICircleService _circleService;


        public CircleServiceTests()
        {
            _circleService = new CircleService();
        }


        [Fact]
        public async Task GetArea_ValidCircle_ReturnsCorrectResult()
        {
            var circle = new Circle {Radius = 5};
            const double expectedArea = Math.PI * 5 * 5;

            var actualArea = await _circleService.GetArea(circle);

            Assert.Equal(expectedArea, actualArea);
        }
        
        [Fact]
        public async Task GetPerimeter_ValidCircle_ReturnsCorrectResult()
        {
            var circle = new Circle {Radius = 5};
            var expectedArea = 2 * Math.PI * circle.Radius;

            var actualArea = await _circleService.GetPerimeter(circle);

            Assert.Equal(expectedArea, actualArea);
        }
        
    }
}