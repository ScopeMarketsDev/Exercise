namespace Application.Events;

internal abstract record CustomerEvent(
    string CustomerId,
    int Revision) : Event($"Customer:{CustomerId}", Revision);
