using HelperExtensions.Models;

namespace HelperExtensions;

public static class OpenPeriodExtensions
{
    public static bool Overlaps(this OpenPeriod firstPeriod, OpenPeriod secondPeriod)
    {
        return firstPeriod.StartDateUtc <= (secondPeriod.EndDateUtc ?? DateTime.MaxValue) &&
               (firstPeriod.EndDateUtc ?? DateTime.MaxValue) >= secondPeriod.StartDateUtc;
    }

    public static bool Contains(this OpenPeriod firstPeriod, OpenPeriod secondPeriod)
    {
        return firstPeriod.StartDateUtc <= secondPeriod.StartDateUtc &&
               (firstPeriod.EndDateUtc ?? DateTime.MaxValue) >= (secondPeriod.EndDateUtc ?? DateTime.MaxValue);
    }
}