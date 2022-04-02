using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Helper.Extensions
{
    public static class StringExtensions
    {
        public static bool StartsWith(this string _, params char[] values) => values.Any(v => _.StartsWith(v));

        public static bool StartsWith(this string _, params string[] values) => values.Any(v => _.StartsWith(v));

        public static bool EndsWith(this string _, params char[] values) => values.Any(v => _.EndsWith(v));

        public static bool EndsWith(this string _, params string[] values) => values.Any(v => _.EndsWith(v));

        public static string ReplaceAt(this string _, int startIndex, string value) => _.ReplaceAt(startIndex, _.Length - startIndex, value);

        public static string ReplaceAt(this string _, int startIndex, int count, string value) => _.Remove(startIndex, count).Insert(startIndex, value);

        public static string Base64Encode(this string source) => Convert.ToBase64String(Encoding.UTF8.GetBytes(source));

        public static string GetBetweenChars(this string source, char start, char end)
        {
            if (source == null || !(source.Contains(start) && source.Contains(end)))
                return source;

            int startIndex = source.IndexOf(start);
            int endIndex = source.IndexOf(end);

            return source.Substring(startIndex + 1, endIndex - (startIndex + 1));
        }

        public static string Base64Decode(this string source)
        {
            try
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(source));
            }
            catch
            {
                return "";
            }

        }
    }
}
