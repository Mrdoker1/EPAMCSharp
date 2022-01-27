using System;

namespace StringVerification
{
    public static class IsbnVerifier
    {
        /// <summary>
        /// Verifies if the string representation of number is a valid ISBN-10 identification number of book.
        /// </summary>
        /// <param name="number">The string representation of book's number.</param>
        /// <returns>true if number is a valid ISBN-10 identification number of book, false otherwise.</returns>
        /// <exception cref="ArgumentException">Thrown if number is null or empty or whitespace.</exception>
        public static bool IsValid(string number)
        {
            double checkSum = 0;
            int counter = 0;
            int numCounter = 10;
            int hyphen = 0;

            if (string.IsNullOrEmpty(number) || string.IsNullOrWhiteSpace(number))
            {
                throw new ArgumentException("String is Null or Empty");
            }
            else
            if (number.Length > 13 || number.Length < 10)
            {
                return false;
            }
            else
            {
                foreach (char c in number)
                {
                    counter++;

                    if (char.IsDigit(c))
                    {
                        if (numCounter <= 0)
                        {
                            return false;
                        }

                        double num = char.GetNumericValue(c);
                        checkSum = checkSum + (num * numCounter);
                        numCounter--;
                    }
                    else
                    {
                        if (c == '-' && hyphen <= 3)
                        {
                            if (counter != 2 && counter != 6 && counter != 12)
                            {
                                return false;
                            }

                            hyphen++;
                        }
                        else
                        {
                            if (c == 'X')
                            {
                                checkSum = checkSum + 10;
                                numCounter--;
                            }
                            else
                            {
                                if (char.IsDigit(c))
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }

                if (checkSum % 11 == 0 && checkSum != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}