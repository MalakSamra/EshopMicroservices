using MediatR;

namespace BuildingBlocks.CQRS;

//Empty ICommand (Don't Return Any Response)
public interface ICommand : ICommand<Unit>
{
}

//Command That Produce a Response
public interface ICommand<out TResponse> : IRequest<TResponse>
{
}
