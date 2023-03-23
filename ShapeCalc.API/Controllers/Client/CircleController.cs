using Microsoft.AspNetCore.Mvc;
using ShapeCalc.Database.Models;
using ShapeCalc.Services;

namespace ShapeCalc.API.Controllers.Client
{
    public class CircleController : AbstractClientController
    {
        public CircleController(IServiceContainer serviceContainer) : base(serviceContainer) { }


        [HttpPost]
        public async Task<ActionResult<double>> GetCircleArea([FromBody] Circle circle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var area = await ServiceContainer.CircleService.GetArea(circle);

            return Ok(area);
        }


        [HttpPost]
        public async Task<ActionResult<double>> GetCirclePerimeter([FromBody] Circle circle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var perimeter = await ServiceContainer.CircleService.GetPerimeter(circle);

            return Ok(perimeter);
        }


    }
}