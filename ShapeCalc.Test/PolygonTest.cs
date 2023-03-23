using ShapeCalc.Database.Models;
using ShapeCalc.Services.ShapeServices.PolygonService;
using Xunit;

namespace ShapeCalc.Test
{
    public class PolygonTest
    {
        private readonly IPolygonService _polygonService;
        
        public PolygonTest()
        {
            _polygonService = new PolygonService();
        }


        [Fact]
        public async Task GetArea_ValidPolygons_Square_ReturnsCorrectArea()
        {
            var square = new PolygonPoints()
            {
                X = new List<double> {0, 4, 4, 0},
                Y = new List<double> {0, 0, 4, 4}
            };

            const double expectedArea = 16;

            var actualArea = await _polygonService.GetArea(square);

            Assert.Equal(expectedArea, actualArea);
        }


        [Fact]
        public async Task GetArea_ValidPolygons_nonConvexPentagon_ReturnsCorrectArea()
        {
            var nonConvexPentagon = new PolygonPoints()
            {
                X = new List<double> {0, 2, 3, 1, -1},
                Y = new List<double> {0, 1, 4, 5, 3}
            };

            const double expectedArea = 12;

            var actualArea = await _polygonService.GetArea(nonConvexPentagon);

            Assert.Equal(expectedArea, actualArea);
        }


        [Fact]
        public async Task GetArea_ValidPolygons_convexHexagon_ReturnsCorrectArea()
        {
            var convexHexagon = new PolygonPoints()
            {
                X = new List<double> {0, 3, 5, 4, 2, 0},
                Y = new List<double> {0, 0, 2, 5, 7, 4}
            };

            const double expectedArea = 24.5;

            var actualArea = await _polygonService.GetArea(convexHexagon);

            Assert.Equal(expectedArea, actualArea);
        }
    }
}