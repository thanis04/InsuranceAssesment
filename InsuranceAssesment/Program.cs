using InsuranceAssesment.Business_Layer.Services;
using InsuranceAssesment.Business_Layer.Services.IServices;
using InsuranceAssesment.Data_Layer.Entities;
using InsuranceAssesment.Data_Layer.Repository;
using InsuranceAssesment.Data_Layer.Repository.IRepository;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddLogging();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("InsuranceDb"));
builder.Services.AddScoped<IPolicyRepository, PolicyRepository>();
builder.Services.AddScoped<IPolicyService, PolicyService>();


var app = builder.Build();

app.UseExceptionHandler(errorApp =>
{
    errorApp.Run(async context =>
    {
        var error = context.Features.Get<IExceptionHandlerPathFeature>()?.Error;
        context.Response.StatusCode = 500;
        await context.Response.WriteAsJsonAsync(new { error = error?.Message });
    });
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
