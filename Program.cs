var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/getfile", async () =>
{
    var filePath = Environment.GetEnvironmentVariable("PATH_TO_FILE");
    if (!string.IsNullOrEmpty(filePath) && File.Exists(filePath))
        return await File.ReadAllTextAsync(filePath);
    return $"Could not find {filePath}";
});

app.Run();
