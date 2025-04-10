namespace HelperExtensions;

public static class GuidExtensions
{
    public static bool IsNullOrEmpty(this Guid? id)
    {
        return !id.HasValue || id == Guid.Empty;
    }
}