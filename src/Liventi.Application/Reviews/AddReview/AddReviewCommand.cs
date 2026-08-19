using Liventi.Application.Abstractions.Messaging;

namespace Liventi.Application.Reviews.AddReview;

public sealed record AddReviewCommand(Guid BookingId, int Rating, string Comment) : ICommand;