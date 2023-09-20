namespace WrathForged.Database
{
    public static class ExtMethods
    {
        public static string ToHexString(this byte[] byteArray, bool reverse = false)
        {
            return reverse
                ? byteArray.Reverse().Aggregate("", (current, b) => current + b.ToString("X2"))
                : byteArray.Aggregate("", (current, b) => current + b.ToString("X2"));
        }
    }
}
