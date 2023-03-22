using Microsoft.AspNetCore.Mvc;
using ShapeCalc.Database.Models;
using ShapeCalc.Services;

namespace ShapeCalc.API.Controllers.Client;

public class SquareController : AbstractClientController
{
    
    
    [HttpPost]
    public async Task<ActionResult<double>> GetSquareArea([FromBody] Square square)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var shapeService = ShapeServiceFactory.Create();
        var area = await shapeService.GetArea(square);

        if (area <= 0)
        {
            return BadRequest("Invalid data of square side");
        }

        return Ok(area);
    }


    [HttpPost]
    public async Task<ActionResult<double>> GetSquarePerimeter([FromBody] Square square)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var shapeService = ShapeServiceFactory.Create();
        var perimeter = await shapeService.GetPerimeter(square);

        if (perimeter <= 0)
        {
            return BadRequest("Invalid data of square side");
        }

        return Ok(perimeter);
    }
}