namespace HelperExtensions;

public static class StringExtensions
{
    public static int GetInt(this string value) =>
        int.TryParse(string.IsNullOrWhiteSpace(value) ? "0" : value, out var result) ? result : 0;

    public static decimal GetDecimal(this string value) =>
        decimal.TryParse(string.IsNullOrWhiteSpace(value) ? "0" : value, out var result) ? result : 0;

    public static string Truncate(this string value, int maxLength) =>
        value.Substring(0, Math.Min(value.Length, maxLength));

    public static bool ToBoolean(this string value)
    {
        value = string.IsNullOrWhiteSpace(value) ? "false" : value;

        switch (value)
        {
            case "0":
                return false;
            case "1":
                return true;
            default:
            {
                bool.TryParse(value, out var result);
                return result;
            }
        }
    }

}