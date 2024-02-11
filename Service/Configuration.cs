using Application;
using Application.Commands;

namespace Service;

internal static class Configuration
{
    internal static void RegisterServices(this WebApplicationBuilder builder)
    {
        builder
            .Services
            .AddEndpointsApiExplorer()
            .AddSwaggerGen()
            .AddScoped<ICommandHandler<CreateCustomerCommand, string>, CreateCustomerHandler>();
    }

    internal static void RegisterMiddleware(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app
                .UseSwagger()
                .UseSwaggerUI();
        }
    }
}
