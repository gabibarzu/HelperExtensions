namespace HelperExtensions.Models;

public class OpenPeriod(DateTime startDateUtc, DateTime? endDateUtc)
{
    public DateTime StartDateUtc { get; set; } = startDateUtc;
    public DateTime? EndDateUtc { get; set; } = endDateUtc;
}
