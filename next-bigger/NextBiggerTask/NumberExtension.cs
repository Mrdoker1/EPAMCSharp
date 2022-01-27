using System;
using System.Text.RegularExpressions;

namespace NextBiggerTask
{
    public static class NumberExtension
    {
        /// <summary>
        /// Finds the nearest largest integer consisting of the digits of the given positive integer number and null if no such number exists.
        /// </summary>
        /// <param name="number">Source number.</param>
        /// <returns>
        /// The nearest largest integer consisting of the digits  of the given positive integer and null if no such number exists.
        /// </returns>
        /// <exception cref="ArgumentException">Thrown when source number is less than 0.</exception>
        public static int? NextBiggerThan(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"Value of {nameof(number)} cannot be less zero.");
            }

            if (number == int.MaxValue)
            {
                return null;
            }

            int numLenth = (int)Math.Log10(number) + 1;

            int[] nums = IntToArray(number);

            try
            {
                if (numLenth < 2)
                {
                    return null;
                }

                int firstDecrasing = -1;

                for (int i = numLenth - 2; i >= 0; i--)
                {
                    if (nums[i] < nums[i + 1])
                    {
                        firstDecrasing = i;
                        break;
                    }
                }

                if (firstDecrasing != -1)
                {
                    int temp = -1;
                    for (int i = firstDecrasing + 1; i < numLenth; i++)
                    {
                        if (nums[i] > nums[firstDecrasing])
                        {
                            temp = temp != -1 && nums[temp] < nums[i] ? temp : i;
                        }
                        else
                        {
                            break;
                        }
                    }

                    int current = nums[temp];
                    nums[temp] = nums[firstDecrasing];
                    nums[firstDecrasing] = current;
                }
                else
                {
                    return null;
                }

                Array.Reverse(nums, firstDecrasing + 1, numLenth - firstDecrasing - 1);

                string s = new string(Array.ConvertAll(nums, x => (char)('0' + x)));

                return Convert.ToInt32(s);
            }
            catch
            {
                throw new NotImplementedException("Exception");
            }
        }

        public static int GetDigit(int x, int digitNumber)
        {
            int digitCount = (int)Math.Log10(x) + 1;
            if (digitNumber > digitCount)
            {
                return 0;
            }

            var pow = (int)Math.Pow(10, digitCount - digitNumber);
            return (x / pow) % 10;
        }

        public static bool HasNumber(int number, int existNum)
        {
            while (number > 0)
            {
                if (number % 10 == existNum)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }

        public static int[] IntToArray(int n)
        {
            int j = 0;
            int len = Convert.ToString(n).Length;
            int[] arr = new int[len];
            while (n != 0)
            {
                arr[len - j - 1] = n % 10;
                n = n / 10;
                j++;
            }

            return arr;
        }
    }
}