using Microsoft.AspNetCore.Mvc;
using ShapeCalc.Database.Models;
using ShapeCalc.Services;

namespace ShapeCalc.API.Controllers.Client
{
    public class ShapeController : AbstractClientController
    {
        public ShapeController(IServiceContainer serviceContainer) : base(serviceContainer) { }


        [HttpPost]
        public async Task<IActionResult> GetPolygonArea([FromBody] PolygonPoints request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            if (request.X.Count != request.Y.Count || request.X.Count < 3)
            {
                return BadRequest("Invalid input data.");
            }

            var area = await ServiceContainer.PolygonService.GetArea(request);

            return Ok(area);
        }

    }
}