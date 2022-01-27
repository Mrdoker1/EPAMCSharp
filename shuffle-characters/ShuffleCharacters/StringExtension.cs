using System;

namespace ShuffleCharacters
{
    public static class StringExtension
    {
        /// <summary>
        /// Shuffles characters in source string according some rule.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="count">The count of iterations.</param>
        /// <returns>Result string.</returns>
        /// <exception cref="ArgumentException">Source string is null or empty or white spaces.</exception>
        /// <exception cref="ArgumentException">Count of iterations less than 0.</exception>
        public static string ShuffleChars(string source, int count)
        {
            {
                if (string.IsNullOrEmpty(source) || string.IsNullOrEmpty(source.Trim()))
                {
                    throw new ArgumentException("ArgumentException", nameof(source));
                }

                if (count < 0)
                {
                    throw new ArgumentException("ArgumentException", nameof(count));
                }

                string resultString = source;
                string oddString = string.Empty;
                string evenString = string.Empty;
                int counter = 0;
                int maxIteration = MaxIterationCount(source, count);

                if (count > maxIteration)
                {
                    double bbb = (double)count / (double)maxIteration;
                    int aaa = Convert.ToInt32(Math.Floor(bbb));
                    count = count - (maxIteration * aaa);
                }

                for (int i = 0; i < count; i++)
                {
                    foreach (char c in resultString)
                    {
                        counter++;

                        if (counter % 2 == 0)
                        {
                            evenString = string.Concat(evenString, c);
                        }
                        else
                        {
                            oddString = string.Concat(oddString, c);
                        }
                    }

                    resultString = string.Concat(oddString, evenString);

                    counter = 0;
                    oddString = string.Empty;
                    evenString = string.Empty;
                }

                return resultString;
            }
        }

        public static int MaxIterationCount(string source, int count)
        {
            if (string.IsNullOrEmpty(source))
            {
                throw ArgumentException(nameof(source));
            }

            string resultString = source;
            string oddString = string.Empty;
            string evenString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                for (int j = 1; j < resultString.Length; j += 2)
                {
                    evenString = string.Concat(evenString, resultString[j]);
                }

                for (int j = 0; j < resultString.Length; j += 2)
                {
                    oddString = string.Concat(oddString, resultString[j]);
                }

                resultString = string.Concat(oddString, evenString);

                if (source == resultString)
                {
                    return i + 1;
                }

                oddString = string.Empty;
                evenString = string.Empty;
            }

            return count;
        }

        private static Exception ArgumentException(string v)
        {
            throw new NotImplementedException();
        }
    }
}
