using Liventi.Domain.Abstractions;

namespace Liventi.Domain.Bookings.Events;

public record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;
