using ShapeCalc.Database.Models;
using ShapeCalc.Services.Services;
using Xunit;

namespace ShapeCalc.Test
{
    public class TriangleTest
    {
        private readonly ITriangleService _triangleService;

        public TriangleTest()
        {
            _triangleService = new TriangleService();
        }

        [Fact]
        public async Task GetArea_ValidTriangle_ReturnsCorrectArea()
        {
            var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
            const double expectedArea = 6.0;
            
            var actualArea = await _triangleService.GetArea(triangle);
            
            Assert.Equal(expectedArea, actualArea);
        }
        
        [Fact]
        public async Task GetArea_InvalidTriangle_Return_0_If_InvalidArea()
        {
            var badTriangle = new Triangle { SideA = 1, SideB = 3, SideC = 50 };
            var actualArea = await _triangleService.GetArea(badTriangle);
            
            const int expectedValue = 0;
            Assert.Equal(expectedValue, actualArea);
        }


        [Fact]
        public async Task IsRightAngle_ValidTriangle_ReturnsTrue()
        {
            var triangle = new Triangle { SideA = 3, SideB = 4, SideC = 5 };
            
            var isRightAngle = await _triangleService.IsRightAngle(triangle);
            
            Assert.True(isRightAngle);
        }

        [Fact]
        public async Task IsRightAngle_InvalidTriangle_ReturnsFalse()
        {
            var triangle = new Triangle { SideA = 1, SideB = 2, SideC = 5 };
            
            var isRightAngle = await _triangleService.IsRightAngle(triangle);
            
            Assert.False(isRightAngle);
        }
    }
}