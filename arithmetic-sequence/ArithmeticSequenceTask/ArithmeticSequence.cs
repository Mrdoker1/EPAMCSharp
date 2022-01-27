using System;

namespace ArithmeticSequenceTask
{
    public static class ArithmeticSequence
    {
        /// <summary>
        /// Calculates the sum of the first 'count' elements of a sequence in which each element is the sum of the given integer 'number'
        /// and number of occurrences of the given integer 'add', based on the element's position within the sequence.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="add">The term.</param>
        /// <param name="count">The number of occurrences.</param>
        /// <returns>Calculated sum.</returns>
        /// <exception cref="OverflowException">
        /// Thrown when number is int.MaxValue and term more then 0
        /// - or -
        /// number is int.MinValue and term less then 0.
        /// </exception>
        /// <exception cref="ArgumentException">Throw if count less then zero.</exception>
        public static int Calculate(int number, int add, int count)
        {
            if (number == int.MaxValue && add > 0)
            {
                throw new OverflowException("The obtained result out of range of integer values.");
            }

            if (number == int.MinValue && add < 0)
            {
                throw new OverflowException("The count of elements of the sequence cannot be less or equals zero.");
            }

            if (count < 0)
            {
                throw new ArgumentException("The count less then zero.");
            }

            int result = 0;
            int x = -1;

            for (int i = 0; i < count; i++)
            {
                result = result + number;
                x++;

                for (int j = count - x; j < count; j++)
                {
                    result = result + add;
                }
            }

            return result;
        }
    }
}