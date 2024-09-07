using DinnerApp.Application.Common.Interfaces.Services;

namespace DinnerApp.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}