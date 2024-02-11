namespace Application.Events;

public abstract record Event(
    string StreamId,
    int Revision)
{
    public DateTime EventTime { get; } = DateTime.UtcNow;
}
