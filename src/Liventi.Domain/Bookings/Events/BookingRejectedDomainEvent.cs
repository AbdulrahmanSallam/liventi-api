using Liventi.Domain.Abstractions;

namespace Liventi.Domain.Bookings.Events;

public record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;