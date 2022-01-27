using System;
using System.Globalization;

#pragma warning disable CA1822

namespace TransformToWordsTask
{
    /// <summary>
    /// Provides transformer methods.
    /// </summary>
    public sealed class Transformer
    {
        /// <summary>
        /// Converts number's digital representation into words.
        /// </summary>
        /// <param name="number">Number to convert.</param>
        /// <returns>Words representation.</returns>
        public string TransformToWords(double number)
        {
            string num = Convert.ToString(number, new CultureInfo("en-US"));
            string name = string.Empty;
            string result = string.Empty;

            if (number == double.Epsilon)
            {
                return "Double Epsilon";
            }

            if (double.IsNaN(number))
            {
                return "NaN";
            }

            if (double.IsPositiveInfinity(number))
            {
                return "Positive Infinity";
            }

            if (double.IsNegativeInfinity(number))
            {
                return "Negative Infinity";
            }

            foreach (char c in num)
            {
                switch (c)
                {
                    case '1':
                        name = "one";
                        break;
                    case '2':
                        name = "two";
                        break;
                    case '3':
                        name = "three";
                        break;
                    case '4':
                        name = "four";
                        break;
                    case '5':
                        name = "five";
                        break;
                    case '6':
                        name = "six";
                        break;
                    case '7':
                        name = "seven";
                        break;
                    case '8':
                        name = "eight";
                        break;
                    case '9':
                        name = "nine";
                        break;
                    case '0':
                        name = "zero";
                        break;
                    case '.':
                        name = "point";
                        break;
                    case '-':
                        name = "minus";
                        break;
                    case '+':
                        name = "plus";
                        break;
                    case 'E':
                        name = "E";
                        break;
                    case 'd':
                        name = "d";
                        break;
                }

                result = string.Concat(result, ' ', name);
            }

            return Convert.ToString(char.ToUpper(result[1], new CultureInfo("en-US")), new CultureInfo("en-US")) + result.Substring(2);
        }
    }
}