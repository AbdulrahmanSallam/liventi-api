using Liventi.Application.Abstractions.Clock;

namespace Liventi.Infrastructure.Clock;

internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}