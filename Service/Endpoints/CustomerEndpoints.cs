using Application;
using Application.Commands;
using Service.DataContracts;

namespace Service.Endpoints;

internal static class CustomerEndpoints
{
    internal static void MapCustomerEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("customers").WithTags("Customers").WithOpenApi();

        group.MapPost(
            "/",
            (CreateCustomer createCustomer, ICommandHandler<CreateCustomerCommand, string> handler) =>
                handler.Handle(new CreateCustomerCommand(createCustomer.FirstName, createCustomer.LastName, createCustomer.EmailAddress)));
    }
}
