namespace HelperExtensions;

public static class DecimalExtensions
{
    public static bool IsBetween(this decimal value, decimal minValue, decimal maxValue)
    {
        return value >= minValue && value <= maxValue;
    }

    public static decimal TruncateToNrOfDecimals(this decimal value, int numberOfDecimals)
    {
        var decimals = (decimal)Math.Pow(10, numberOfDecimals);
        return Math.Truncate(value * decimals) / decimals;
    }
}