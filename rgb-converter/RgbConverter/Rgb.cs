using System;
using System.Drawing;
using System.Globalization;

namespace RgbConverter
{
    public static class Rgb
    {
        /// <summary>
        /// Gets hexadecimal representation source RGB decimal values.
        /// </summary>
        /// <param name="red">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="green">The valid decimal value for RGB is in the range 0-255.</param>
        /// <param name="blue">The valid decimal value for RGB is in the range 0-255.</param>
        /// <returns>Returns hexadecimal representation source RGB decimal values.</returns>
        public static string GetHexRepresentation(int red, int green, int blue)
        {
            int[] array = { red, green, blue };
            string hexValue = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 255)
                {
                    array[i] = 255;
                }
                else if (array[i] < 0)
                {
                    array[i] = 0;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (array[i].ToString("X", CultureInfo.GetCultureInfo("ru-RU")).Length < 2)
                {
                    hexValue = string.Concat(hexValue, "0", array[i].ToString("X", CultureInfo.GetCultureInfo("ru-RU")));
                }
                else
                {
                    hexValue = string.Concat(hexValue, array[i].ToString("X", CultureInfo.GetCultureInfo("ru-RU")));
                }
            }

            return hexValue;
        }
    }
}