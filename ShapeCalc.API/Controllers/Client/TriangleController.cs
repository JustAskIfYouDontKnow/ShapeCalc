using Microsoft.AspNetCore.Mvc;
using ShapeCalc.Database.Models;
using ShapeCalc.Services;

namespace ShapeCalc.API.Controllers.Client;

public class TriangleController : AbstractClientController
{
    

    [HttpPost]
    public async Task<ActionResult<double>> GetTriangleArea([FromBody] Triangle triangle)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var shapeService = ShapeServiceFactory.Create();
        var area = await shapeService.GetArea(triangle);

        if (area == 0)
        {
            return BadRequest("Invalid data of triangle sides");
        }

        return Ok(area);
    }


    [HttpPost]
    public async Task<ActionResult<bool>> IsTriangleRightAngle([FromBody] Triangle triangle)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var shapeService = ShapeServiceFactory.Create();
        var isRightAngle = await shapeService.IsRightAngle(triangle);

        return Ok(isRightAngle);
    }

}