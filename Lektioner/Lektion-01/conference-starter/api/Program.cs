var builder = WebApplication.CreateBuilder(args);

// =====================================================================
// Services and dependencies...
// =====================================================================

builder.Services.AddControllers();

var app = builder.Build();

// =====================================================================
// Pipeline...
// =====================================================================

app.MapControllers();

app.Run();
