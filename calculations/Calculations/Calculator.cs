using System;

namespace Calculations
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumOne(int n)
        {
            try
            {
                double sum = 0;

                for (int i = 1; i < n + 1; i++)
                {
                    sum += 1.0 / i;
                }

                return sum;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumTwo(int n)
        {
            try
            {
                double sum = 0;
                int pow = -1;

                for (int i = 1; i < n + 1; i++)
                {
                    pow *= -1;
                    sum += pow / (i * (i + 1.0));
                }

                return sum;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumThree(int n)
        {
            try
            {
                double sum = 0;
                int pow = 5;

                for (int i = 1; i < n + 1; i++)
                {
                    sum += 1 / Math.Pow(i, pow);
                }

                return sum;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFour(int n)
        {
            try
            {
                double sum = 0;

                for (int i = 1; i < n + 1; i++)
                {
                    sum += 1.0 / (((2 * i) + 1.0) * ((2 * i) + 1.0));
                }

                return sum;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetProductOne(int n)
        {
            try
            {
                double sum = 1;

                for (int i = 1; i < n + 1; i++)
                {
                    sum *= 1.0 + (1.0 / ((double)i * (double)i));
                }

                return sum;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFive(int n)
        {
            try
            {
                double sum = 0;
                int pow = 1;

                for (int i = 1; i < n + 1; i++)
                {
                    pow *= -1;
                    sum += pow / ((2.0 * (double)i) + 1.0);
                }

                return sum;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Calculate the following sum
        /// 1!/1 + 2!/(1+1/2) + 3!/(1+1/2+1/3) + ... + 1*2*...* n/ (1+1/2+1/3+...+1/n), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSix(int n)
        {
            if (n >= 1000000)
            {
                return double.PositiveInfinity;
            }

            try
            {
                double sum = 0;
                double result = 0;

                for (int i = 1; i <= n; i++)
                {
                    double factorial = 1;

                    for (int j = 1; j <= i; j++)
                    {
                        factorial *= (double)j;
                        result += 1.0 / (double)j;
                    }

                    sum += factorial / result;
                    result = 0;
                }

                return sum;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Calculate the following sum
        /// Sqrt(2 + Sqrt(2 + ... + Sqrt(2))), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSeven(int n)
        {
            try
            {
                double sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum = Math.Sqrt(2 + sum);
                }

                return sum;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/sin(1) + 1/(sin(1)+sin(2)) + ...+  1/(sin(1)+sin(2)+...+sin(n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumEight(int n) 
        {
            try
            {
                double sum = 0;
                double sum2 = 0;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        sum2 += Math.Sin(j * (Math.PI / 180.0));
                    }

                    sum += 1d / sum2;
                    sum2 = 0;
                }

                return sum;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}