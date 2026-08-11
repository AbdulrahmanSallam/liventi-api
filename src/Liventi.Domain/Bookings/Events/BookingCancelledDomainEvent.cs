using Liventi.Domain.Abstractions;

namespace Liventi.Domain.Bookings.Events;

public record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;
