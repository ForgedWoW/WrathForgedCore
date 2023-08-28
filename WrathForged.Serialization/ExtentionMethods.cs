using System;
using System.Text;

namespace WrathForged.Serialization
{
    public static class ExtentionMethods
    {
        public static byte[] ToCString(this string str)
        {
            var utf8StringBytes = Encoding.UTF8.GetBytes(str);
            var data = new byte[utf8StringBytes.Length + 1];
            Array.Copy(utf8StringBytes, data, utf8StringBytes.Length);
            data[data.Length - 1] = 0;
            return data;
        }
    }
}
