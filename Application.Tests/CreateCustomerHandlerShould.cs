using Application.Commands;
using Application.Events;
using Application.Ports;

namespace Application.Tests;

public class CreateCustomerHandlerShould
{
    [Fact]
    public void WhenHandleCalled_WriteEvent()
    {
        // Arrange
        var mockEventRepo = Substitute.For<IEventRepository>();
        var handler = new CreateCustomerHandler(mockEventRepo);
        var testCommand = new CreateCustomerCommand("Joe", "Bloggs", "joe.bloggs@example.com");

        // Act
        var expectedCustomerId = handler.Handle(testCommand);

        // Assert
        mockEventRepo
            .Received()
            .WriteEvent(Arg.Is<CustomerCreatedEvent>(e =>
                e.CustomerId == expectedCustomerId &&
                e.FirstName == testCommand.FirstName &&
                e.LastName == testCommand.LastName &&
                e.EmailAddress == testCommand.EmailAddress));
    }
}