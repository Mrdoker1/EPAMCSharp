    using System;

    namespace PrimeFactorsTask
{
    public static class PrimeFactors
    {
        /// <summary>
        /// Compute the prime factors of a given natural number.
        /// A prime number is only evenly divisible by itself and 1.
        /// Note that 1 is not a prime number.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>Prime factors of a given natural number.</returns>
        /// <exception cref="ArgumentException">Thrown when number less or equal 0.</exception>
        /// <example>
        /// 60 => {2, 2, 3, 5}
        /// 8 => {2, 2, 2}
        /// 12 => {2, 2, 3}
        /// 901255 => {5, 17, 23, 461}
        /// 93819012551 => {11, 9539, 894119}
        /// </example>
        public static int[] GetFactors(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException($"{number} cannot be less or equals zero.", nameof(number));
            }

            if (number == 1)
            {
                return Array.Empty<int>();
            }

            int num = number;
            int[] arr = new int[number];
            int counter = -1;

            while (num != 1)
            {
                for (int divider = 2; divider <= num; divider++)
                {
                    if (num % divider == 0)
                    {
                        arr[++counter] = divider;
                        num = num / divider;
                        break;
                    }
                }
            }

            int[] result = new int[counter + 1];

            for (int i = 0; i <= counter; i++)
            {
                result[i] = arr[i];
            }

            return result;
        }
    }
}
