using Microsoft.OpenApi.Models;
using ShapeCalc.Services;
using ShapeCalc.Services.ShapeServices.CircleService;
using ShapeCalc.Services.ShapeServices.SquareService;
using ShapeCalc.Services.ShapeServices.TriangleService;

namespace ShapeCalc.API;

public class Startup
{
    public IConfiguration Configuration { get; }


    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new OpenApiInfo {Title = "ShapeCalc_Api", Version = "v1"}); });
        
        services.AddScoped<IServiceContainer, ServiceContainer>();

        services.AddControllers();
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ShapeCalc_Api v1"));
        }

        app.UseRouting();
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }

}