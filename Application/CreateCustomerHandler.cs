using Application.Commands;

namespace Application;

public class CreateCustomerHandler() : ICommandHandler<CreateCustomerCommand, string>
{
    public string Handle(CreateCustomerCommand command)
    {
        var customerId = Guid.NewGuid().ToString();

        return customerId;
    }
}
