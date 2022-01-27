using System;

namespace Gcd
{
    /// <summary>
    /// Provide methods with integers.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                return Math.Abs(RunGcdByEuclidean(b, a % b));
            }
        }

        public static int RunGcdByEuclidean(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                return Math.Abs(RunGcdByEuclidean(b, a % b));
            }
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            int[] arr = new int[3] { a, b, c };
            int gcd = RunGcdByEuclidean(arr[0], arr[1]);

            for (int i = 1; i < arr.Length - 1; i++)
            {
                gcd = RunGcdByEuclidean(gcd, arr[i + 1]);
            }

            return gcd;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(int a, int b, params int[] other)
        {
            int[] arr = new int[2 + other.Length];
            int counter = a + b;

            arr[0] = a;
            arr[1] = b;

            for (int i = 2; i < other.Length + 2; i++)
            {
                arr[i] = other[i - 2];
                counter = counter + arr[i];
            }

            if (counter == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            int gcd = RunGcdByEuclidean(arr[0], arr[1]);
            for (int i = 1; i < arr.Length - 1; i++)
            {
                gcd = RunGcdByEuclidean(gcd, arr[i + 1]);
            }

            return gcd;
        }

        /// <summary>
        /// Calculates GCD of two integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            if (a == 0 && b == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            if (b == 0)
            {
                return Math.Abs(a);
            }
            else
            {
                return Math.Abs(RunGcdByStein(b, a % b));
            }
        }

        public static int RunGcdByStein(int a, int b)
        {
            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"Number cannot be {int.MinValue}.");
            }

            int value1 = Math.Abs(a);
            int value2 = Math.Abs(b);

            if (value1 == 0)
            {
                return value2;
            }

            if (value2 == 0)
            {
                return value1;
            }

            if (value1 == value2)
            {
                return value1;
            }

            bool val1IsEven = (value1 & 1u) == 0;
            bool val2IsEven = (value2 & 1u) == 0;

            if (val1IsEven && val2IsEven)
            {
                return RunGcdByStein(value1 >> 1, value2 >> 1) << 1;
            }
            else if (val1IsEven && !val2IsEven)
            {
                return RunGcdByStein(value1 >> 1, value2);
            }
            else if (val2IsEven)
            {
                return RunGcdByStein(value1, value2 >> 1);
            }
            else if (value1 > value2)
            {
                return RunGcdByStein((value1 - value2) >> 1, value2);
            }
            else
            {
                return RunGcdByStein(value1, (value2 - value1) >> 1);
            }
        }

        /// <summary>
        /// Calculates GCD of three integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, int c)
        {
            if (a == 0 && b == 0 && c == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            int[] arr = new int[3] { a, b, c };
            int gcd = RunGcdByStein(arr[0], arr[1]);

            for (int i = 1; i < arr.Length - 1; i++)
            {
                gcd = RunGcdByStein(gcd, arr[i + 1]);
            }

            return gcd;
        }

        /// <summary>
        /// Calculates the GCD of integers [-int.MaxValue;int.MaxValue] by the Stein algorithm.
        /// </summary>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(int a, int b, params int[] other)
        {
            int[] arr = new int[2 + other.Length];
            int counter = a + b;

            arr[0] = a;
            arr[1] = b;

            for (int i = 2; i < other.Length + 2; i++)
            {
                arr[i] = other[i - 2];
                counter = counter + arr[i];
            }

            if (counter == 0)
            {
                throw new ArgumentException("All numbers cannot be 0 at the same time.");
            }

            int gcd = RunGcdByStein(arr[0], arr[1]);
            for (int i = 1; i < arr.Length - 1; i++)
            {
                gcd = RunGcdByStein(gcd, arr[i + 1]);
            }

            return gcd;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int result = GetGcdByEuclidean(a, b);

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, int c)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int result = GetGcdByEuclidean(a, b, c);

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Euclidean algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByEuclidean(out long elapsedTicks, int a, int b, params int[] other)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int result = GetGcdByEuclidean(a, b, other);

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates GCD of two integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or two numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int result = GetGcdByStein(a, b);

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates GCD of three integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="c">Third integer.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, int c)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int result = GetGcdByStein(a, b, c);

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }

        /// <summary>
        /// Calculates the GCD of integers from [-int.MaxValue;int.MaxValue] by the Stein algorithm with elapsed time.
        /// </summary>
        /// <param name="elapsedTicks">Method execution time in Ticks.</param>
        /// <param name="a">First integer.</param>
        /// <param name="b">Second integer.</param>
        /// <param name="other">Other integers.</param>
        /// <returns>The GCD value.</returns>
        /// <exception cref="ArgumentException">Thrown when all numbers are 0 at the same time.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when one or more numbers are int.MinValue.</exception>
        public static int GetGcdByStein(out long elapsedTicks, int a, int b, params int[] other)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            int result = GetGcdByStein(a, b, other);

            watch.Stop();
            elapsedTicks = watch.ElapsedTicks;
            return result;
        }
    }
}
