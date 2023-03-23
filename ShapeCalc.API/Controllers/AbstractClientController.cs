using Microsoft.AspNetCore.Mvc;
using ShapeCalc.Services;

namespace ShapeCalc.API.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public abstract class AbstractClientController : ControllerBase
{
    protected IServiceContainer ServiceContainer;

    protected AbstractClientController(IServiceContainer serviceContainer)
    {
        ServiceContainer = serviceContainer;
    }
}