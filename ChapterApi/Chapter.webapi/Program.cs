using Chapter.webapi.Context;
using Chapter.webapi.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ChapterContext,ChapterContext>();
builder.Services.AddControllers();
builder.Services.AddTransient<LivrosRepository,LivrosRepository>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
});

app.Run();