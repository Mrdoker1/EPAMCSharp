using System;
using System.Collections.Generic;
using System.Linq;

#pragma warning disable SA1615
#pragma warning disable SA1611
#pragma warning disable S2234

namespace WorkingWithStrings
{
    public static class ConcatenatingStrings
    {
        /// <summary>
        /// Concatenates two specified instances of <see cref="string"/>.
        /// </summary>
        public static string ConcatenateStrings(string str1, string str2)
        {
            return string.Concat(str1, str2);
        }

        /// <summary>
        /// Concatenates three specified instances of <see cref="string"/>.
        /// </summary>
        public static string ConcatenateStrings(string str1, string str2, string str3)
        {
            return string.Concat(str1, str2, str3);
        }

        /// <summary>
        /// Concatenates four specified instances of <see cref="string"/>.
        /// </summary>
        public static string ConcatenateStrings(string str1, string str2, string str3, string str4)
        {
            return string.Concat(str1, str2, str3, str4);
        }

        /// <summary>
        /// Concatenates the members of an <see cref="IEnumerable{T}"/> implementation.
        /// </summary>
        public static string ConcatenateStrings(IEnumerable<string> strings)
        {
            return string.Concat(strings);
        }

        /// <summary>
        /// Concatenates the string representations of three specified objects.
        /// </summary>
        public static string ConcatenateValues(string str, int intValue, long longValue)
        {
            return string.Concat(str, intValue, longValue);
        }

        /// <summary>
        /// Concatenates the string representations of four specified objects.
        /// </summary>
        public static string ConcatenateValues(short shortValue, float floatValue, bool boolValue, double doubleValue)
        {
            return string.Concat(shortValue, floatValue, boolValue, doubleValue);
        }

        /// <summary>
        /// Concatenates the members of an <see cref="IEnumerable{T}"/> implementation.
        /// </summary>
        public static string ConcatenateValues(IEnumerable<object> values)
        {
            return string.Concat(values);
        }
    }
}
