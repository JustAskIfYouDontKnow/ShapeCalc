using Microsoft.AspNetCore.Mvc;
using ShapeCalc.Database.Models;
using ShapeCalc.Services.Services;

namespace ShapeCalc.API.Controllers.Client
{
    public class CircleController : AbstractClientController
    {
        private readonly ICircleService _circleService;


        public CircleController(ICircleService circleService)
        {
            _circleService = circleService;
        }


        [HttpPost]
        public async Task<ActionResult<double>> GetCircleArea([FromBody] Circle circle)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var area = await _circleService.GetArea(circle);
            
            if (area == 0)
            {
                return BadRequest("Invalid data of circle radius");
            }

            return Ok(area);
        }
    }
}