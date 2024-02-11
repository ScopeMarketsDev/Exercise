namespace Application.Events;

internal record CustomerCreatedEvent(
    string CustomerId,
    string FirstName,
    string LastName,
    string EmailAddress) : CustomerEvent(CustomerId, 1);
