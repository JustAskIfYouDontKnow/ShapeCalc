using Microsoft.AspNetCore.Mvc;
using ShapeCalc.Database.Models;
using ShapeCalc.Services;

namespace ShapeCalc.API.Controllers.Client;

public class SquareController : AbstractClientController
{

    public SquareController(IServiceContainer serviceContainer) : base(serviceContainer) { }


    [HttpPost]
    public async Task<ActionResult<double>> GetSquareArea([FromBody] Square square)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var area = await ServiceContainer.SquareService.GetArea(square);

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

        var perimeter = await ServiceContainer.SquareService.GetPerimeter(square);

        if (perimeter <= 0)
        {
            return BadRequest("Invalid data of square side");
        }

        return Ok(perimeter);
    }

}