namespace Application.Commands;

public record CreateCustomerCommand(
    string FirstName,
    string LastName,
    string EmailAddress);
