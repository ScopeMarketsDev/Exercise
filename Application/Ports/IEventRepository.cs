using Application.Events;

namespace Application.Ports;

public interface IEventRepository
{
    void WriteEvent<TEvent>(TEvent @event) where TEvent : Event;
    IEnumerable<TEvent> ReadStream<TEvent>(string streamId) where TEvent : Event;
}
