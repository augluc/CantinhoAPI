using Cantinho.Application.Common.Interfaces.Services;

namespace Cantinho.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}