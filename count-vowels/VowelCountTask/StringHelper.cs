using System;

namespace VowelCountTask
{
    public static class StringHelper
    {
        /// <summary>
        /// Calculates the count of vowels in the source string.
        ///  'a', 'e', 'i', 'o', and 'u' are vowels. 
        /// </summary>
        /// <param name="source">Source string.</param>
        /// <returns>Count of vowels in the given string.</returns>
        /// <exception cref="ArgumentException">Thrown when source string is null or empty.</exception>
        public static int GetCountOfVowel(string source)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw new ArgumentException("String cannot be null or empty.", nameof(source));
            }

            int result = 0;

            foreach (char c in source)
            {
                switch (c)
                {
                    case 'a':
                        result++;
                        break;
                    case 'e':
                        result++;
                        break;
                    case 'i':
                        result++;
                        break;
                    case 'o':
                        result++;
                        break;
                    case 'u':
                        result++;
                        break;
                }
            }

            return result;
        }
    }
}