using Liventi.Domain.Abstractions;

namespace Liventi.Domain.Bookings.Events;

public record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;
