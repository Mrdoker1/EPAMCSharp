using System;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            if (obj1 is null)
            {
                throw new ArgumentNullException(nameof(obj1));
            }
            else if (obj2 is null)
            {
                throw new ArgumentNullException(nameof(obj2));
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }
            else
            {
                return str;
            }
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1))
            {
                throw new ArgumentNullException(nameof(str1));
            }
            else if (string.IsNullOrEmpty(str2))
            {
                throw new ArgumentNullException(nameof(str2));
            }
            else
            {
                return string.Concat(str1, str2);
            }
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber)
        {
            if (evenNumber % 2 == 0)
            {
                return evenNumber;
            }
            else
            {
#pragma warning disable CA2208 // Instantiate argument exceptions correctly
                throw new ArgumentException(nameof(evenNumber));
#pragma warning restore CA2208 // Instantiate argument exceptions correctly
            }
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            if (((candidateAge < 16 || candidateAge > 63) && !isCandidateWoman) ||
                ((candidateAge < 16 || candidateAge > 58) && isCandidateWoman))
            {
                throw new ArgumentOutOfRangeException(nameof(candidateAge));
            }
            else
            {
                return candidateAge;
            }
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(day));
            }
            else if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month));
            }
            else if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username));
            }

            return $"{username}-{day}{month}";
        }
    }
}
