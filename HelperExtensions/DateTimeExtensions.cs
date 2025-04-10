namespace HelperExtensions;

public static class DateTimeExtensions
{
    public static bool IsInRange(this DateTime newDate, DateTime minDate, DateTime maxDate)
    {
        return newDate >= minDate && newDate <= maxDate;
    }

    public static bool IsInRange(this DateTime? newDate, DateTime? minDate, DateTime? maxDate)
    {
        if (!newDate.HasValue || !minDate.HasValue || !maxDate.HasValue)
        {
            return false;
        }

        return newDate.Value >= minDate.Value && newDate.Value <= maxDate.Value;
    }

    public static bool IsInOpenRange(this DateTime newDate, DateTime minDate, DateTime? endDate)
    {
        return minDate <= newDate && (!endDate.HasValue || endDate.Value >= newDate);
    }
}