

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

IConfiguration Configuration;
builder.Services.ConfigurationInfrastructureService(Configuration);
 
Configuration = builder.Configuration;

// call some methods
ConfigureMvc(builder.Services);

void ConfigureMvc(IServiceCollection services)
{
    
    //builder.Services.AddMvc(config =>
    //{
    //    var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    //    config.Filters.Add(new AuthorizeFilter(policy));
    //})
    //.AddRazorPagesOptions(options => { options.Conventions.AddPageRoute("/Home/Login", ""); })
    //.AddJsonOptions(options =>
    //{
    //    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    //    options.JsonSerializerOptions.PropertyNamingPolicy = null;
    //});
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateTime.Now.AddDays(index),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}