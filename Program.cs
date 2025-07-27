using Exo.WebApi.Contexts;
using Exo.WebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ExoContext>();
builder.Services.AddControllers();
builder.Services.AddTransient<ProjetoRepository, ProjetoRepository>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
