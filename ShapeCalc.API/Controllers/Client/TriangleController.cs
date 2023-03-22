using Microsoft.AspNetCore.Mvc;
using ShapeCalc.Database.Models;
using ShapeCalc.Services.Services;

namespace ShapeCalc.API.Controllers.Client;

public class TriangleController : AbstractClientController
{

    private readonly ITriangleService _triangleService;


    public TriangleController(ITriangleService triangleService)
    {
        _triangleService = triangleService;
    }


    [HttpPost]
    public async Task<ActionResult<double>> GetTriangleArea([FromBody] Triangle triangle)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var area =  await _triangleService.GetArea(triangle);

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

        var isRightAngle = await _triangleService.IsRightAngle(triangle);

        return Ok(isRightAngle);
    }

}