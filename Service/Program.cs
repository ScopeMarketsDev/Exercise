using Service;
using Service.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.RegisterServices();

var app = builder.Build();
app.RegisterMiddleware();

app.MapCustomerEndpoints();

app.Run();
