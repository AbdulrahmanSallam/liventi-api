using Liventi.Application.Abstractions.Messaging;

namespace Liventi.Application.Bookings.GetBooking;

public sealed record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;