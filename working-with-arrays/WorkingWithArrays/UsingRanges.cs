using System;

#pragma warning disable CA1062

namespace WorkingWithArrays
{
    public static class UsingRanges
    {
        public static int[] GetArrayWithAllElements(int[] array)
        {
            int[] arr = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }

            return arr;
        }

        public static int[] GetArrayWithoutFirstElement(int[] array)
        {
            int[] arr = array[1..];
            return arr;
        }

        public static int[] GetArrayWithoutTwoFirstElements(int[] array)
        {
            int[] arr = array[2..];
            return arr;
        }

        public static int[] GetArrayWithoutThreeFirstElements(int[] array)
        {
            int[] arr = array[3..];
            return arr;
        }

        public static int[] GetArrayWithoutLastElement(int[] array)
        {
            int[] arr = array[..^1];
            return arr;
        }

        public static int[] GetArrayWithoutTwoLastElements(int[] array)
        {
            int[] arr = array[..^2];
            return arr;
        }

        public static int[] GetArrayWithoutThreeLastElements(int[] array)
        {
            int[] arr = array[..^3];
            return arr;
        }

        public static bool[] GetArrayWithoutFirstAndLastElements(bool[] array)
        {
            bool[] arr = array[1..^1];
            return arr;
        }

        public static bool[] GetArrayWithoutTwoFirstAndTwoLastElements(bool[] array)
        {
            bool[] arr = array[2..^2];
            return arr;
        }

        public static bool[] GetArrayWithoutThreeFirstAndThreeLastElements(bool[] array)
        {
            bool[] arr = array[3..^3];
            return arr;
        }
    }
}
