using Core.Abstractions;
using MediatR;

namespace Application.Abstracttions.Messaging;

public interface ICommand: IRequest<Result>,IBaseCommand

{
    
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand
{

}
public interface IBaseCommand
{
}