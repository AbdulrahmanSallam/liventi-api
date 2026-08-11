using Liventi.Domain.Abstractions;

namespace Liventi.Domain.Users.Events;


public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;