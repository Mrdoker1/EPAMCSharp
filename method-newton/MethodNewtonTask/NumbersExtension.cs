using System;

namespace MethodNewtonTask
{
    public static class NumbersExtension
    {
        /// <summary>
        /// Initializes static members of the <see cref="NumbersExtension"/> class.
        /// </summary>
        public static readonly AppSettings AppSettings = new AppSettings { Epsilon = double.Epsilon };

        /// <summary>
        /// Find n-th root of number with the given accuracy.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <param name="degree">Root degree.</param>
        /// <param name="accuracy">Accuracy value.</param>
        /// <returns> n-th root of number.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when number is negative and n degree is even.
        /// -or- 
        /// degree is less than zero
        /// -or-
        /// number is NaN, double.NegativeInfinity, double.PositiveInfinity.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when accuracy is less than zero.
        /// -or- 
        /// accuracy is more than `Epsilon`.
        /// </exception>
        public static double FindNthRoot(double number, int degree, double accuracy)
        {
            if (accuracy < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(accuracy), "Accuracy cannot be less than zero.");
            }

            if (degree <= 0)
            {
                throw new ArgumentException("Degree can not be less or equal zero.");
            }

            if (accuracy > NumbersExtension.AppSettings.Epsilon)
            {
                throw new ArgumentOutOfRangeException(nameof(accuracy), $"Accuracy should be less than {NumbersExtension.AppSettings.Epsilon}");
            }

            if (number < 0 && (degree & 1u) == 0)
            {
                throw new ArgumentException("A cannot be negative when the n degree is even.");
            }

            if (number == double.PositiveInfinity || number == double.NegativeInfinity || number is double.NaN)
            {
                throw new ArgumentException($"{nameof(number)} is not a finite value");
            }

            double x0 = number;
            double x1 = (1d / degree) * ((x0 * (degree - 1d)) + (number / Math.Pow(x0, degree - 1)));

            while (Math.Abs(x1 - x0) > accuracy)
            {
                x0 = x1;
                x1 = (1d / degree) * ((x0 * (degree - 1d)) + (number / Math.Pow(x0, degree - 1)));
            }

            return x1;
        }
    }
}