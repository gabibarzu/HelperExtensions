namespace HelperExtensions;

public static class ListExtensions
{
    public static List<T> GetListFromItem<T>(this T obj)
    {
        return [obj];
    }
}