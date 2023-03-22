using Microsoft.AspNetCore.Mvc;
using ShapeCalc.Database.Models;
using ShapeCalc.Services;
using ShapeCalc.Services.ShapeServices.CircleService;

namespace ShapeCalc.API.Controllers.Client
{
    public class CircleController : AbstractClientController
    {

        [HttpPost]
        public async Task<ActionResult<double>> GetCircleArea([FromBody] Circle circle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shapeService = ShapeServiceFactory.Create();
            var area = await shapeService.GetArea(circle);

            return Ok(area);
        }
        
        [HttpPost]
        public async Task<ActionResult<double>> GetCirclePerimeter([FromBody] Circle circle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var shapeService = ShapeServiceFactory.Create();
            var perimeter = await shapeService.GetPerimeter(circle);

            return Ok(perimeter);
        }
    }
}