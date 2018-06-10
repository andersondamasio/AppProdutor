namespace com.datacoper.appprodutor.Core.Utils
{
    public static class Extensions
    {
        public static string Truncate(this string value, int maxLength, bool colocarPontinhos = true)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength) + (colocarPontinhos ? "..." : string.Empty);
        }

        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
