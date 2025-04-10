namespace HelperExtensions;

public static class EnumerableExtensions
{
    public static bool IsNullOrEmpty<TSource>(this IEnumerable<TSource>? source)
    {
        return source == null || !source.Any();
    }
}