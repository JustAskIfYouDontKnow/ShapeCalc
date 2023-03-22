using ShapeCalc.Database.Models;
using ShapeCalc.Services.Services;
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
        public async Task GetArea_InvalidCircle_Return_0_If_InvalidArea()
        {
            var circle = new Circle {Radius = -1};
            const double expectedValue = 0;

            var actualArea = await _circleService.GetArea(circle);

            Assert.Equal(expectedValue, actualArea);
        }
    }
}