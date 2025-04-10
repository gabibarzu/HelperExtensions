namespace HelperExtensions;

public static class DictionaryExtensions
{
    public static TValue? GetValueOrDefault<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TKey key, TValue? defaultValue = default) where TKey : notnull
    {
        return dictionary.TryGetValue(key, out var value)
                   ? value
                   : defaultValue;
    }
}