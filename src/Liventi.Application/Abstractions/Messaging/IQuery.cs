using Liventi.Domain.Abstractions;
using MediatR;

namespace Liventi.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}