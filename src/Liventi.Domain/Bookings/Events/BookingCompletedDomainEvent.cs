using Liventi.Domain.Abstractions;

namespace Liventi.Domain.Bookings.Events;

public record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;
