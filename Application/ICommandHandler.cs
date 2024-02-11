namespace Application;

public interface ICommandHandler<TCommand, TResponse>
{
    TResponse Handle(TCommand command);
}
