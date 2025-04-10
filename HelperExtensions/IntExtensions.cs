namespace HelperExtensions
{
    public static class IntExtensions
    {
        public static bool IsBetween(this int number, int left, int right)
        {
            return number >= left && number <= right;
        }
    }
}
