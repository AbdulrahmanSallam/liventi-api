using Liventi.Domain.Abstractions;

namespace Liventi.Domain.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;