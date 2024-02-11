namespace Service.DataContracts;

public record CreateCustomer(
    string FirstName,
    string LastName,
    string EmailAddress);
