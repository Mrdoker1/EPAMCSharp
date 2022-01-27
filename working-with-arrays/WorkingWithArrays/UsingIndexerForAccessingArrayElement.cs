using System;

#pragma warning disable CA1062

namespace WorkingWithArrays
{
    public static class UsingIndexerForAccessingArrayElement
    {
        public static int GetFirstArrayElement(int[] array)
        {
            return array[0];
        }

        public static int GetSecondArrayElement(int[] array)
        {
            return array[1];
        }

        public static int GetThirdArrayElement(int[] array)
        {
            return array[2];
        }

        public static int GetLastElement(int[] array)
        {
            // Use Array.Length property to get an array length: https://docs.microsoft.com/en-us/dotnet/api/system.array.length
            return array[array.Length - 1];
        }

        public static int GetNextToLastElement(int[] array)
        {
            // Use Array.Length property to get an array length: https://docs.microsoft.com/en-us/dotnet/api/system.array.length
            return array[array.Length - 2];
        }

        public static int GetNthArrayElement(int[] array, int n)
        {
            return array[n - 1];
        }

        public static bool GetFirstArrayElement(bool[] array)
        {
            return array[0];
        }

        public static bool GetSecondArrayElement(bool[] array)
        {
            return array[1];
        }

        public static bool GetSixthArrayElement(bool[] array)
        {
            return array[5];
        }

        public static bool GetLastElement(bool[] array)
        {
            // Use Array.Length property to get an array length: https://docs.microsoft.com/en-us/dotnet/api/system.array.length
            return array[array.Length - 1];
        }

        public static bool GetNextToLastElement(bool[] array)
        {
            // Use Array.Length property to get an array length: https://docs.microsoft.com/en-us/dotnet/api/system.array.length
            return array[array.Length - 2];
        }

        public static bool GetNthArrayElement(bool[] array, int n)
        {
            return array[n - 1];
        }

        public static string GetFirstArrayElement(string[] array)
        {
            return array[0];
        }

        public static string GetForthArrayElement(string[] array)
        {
            return array[3];
        }

        public static string GetLastElement(string[] array)
        {
            // Use Array.Length property to get an array length: https://docs.microsoft.com/en-us/dotnet/api/system.array.length
            return array[array.Length - 1];
        }

        public static string GetNextToLastElement(string[] array)
        {
            // Use Array.Length property to get an array length: https://docs.microsoft.com/en-us/dotnet/api/system.array.length
            return array[array.Length - 2];
        }

        public static char GetFirstArrayElement(char[] array)
        {
            return array[0];
        }

        public static char GetSeventhArrayElement(char[] array)
        {
            return array[6];
        }

        public static char GetLastElement(char[] array)
        {
            // Use Array.Length property to get an array length: https://docs.microsoft.com/en-us/dotnet/api/system.array.length
            return array[array.Length - 1];
        }

        public static char GetNextToLastElement(char[] array)
        {
            // Use Array.Length property to get an array length: https://docs.microsoft.com/en-us/dotnet/api/system.array.length
            return array[array.Length - 2];
        }

        public static double GetFirstArrayElement(double[] array)
        {
            return array[0];
        }

        public static double GetSeventhArrayElement(double[] array)
        {
            return array[6];
        }

        public static double GetLastElement(double[] array)
        {
            // Use index from end operator: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return array[array.Length - 1];
        }

        public static double GetNextToLastElement(double[] array)
        {
            // Use index from end operator: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return array[array.Length - 2];
        }

        public static float GetFirstArrayElement(float[] array)
        {
            return array[0];
        }

        public static float GetNinthArrayElement(float[] array)
        {
            return array[8];
        }

        public static float GetLastElement(float[] array)
        {
            // Use index from end operator: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return array[array.Length - 1];
        }

        public static float GetNextToLastElement(float[] array)
        {
            // Use index from end operator: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return array[array.Length - 2];
        }

        public static decimal GetLastElement(decimal[] array)
        {
            // Use index from end operator: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return array[array.Length - 1];
        }

        public static decimal GetNextToLastElement(decimal[] array)
        {
            // Use index from end operator: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return array[array.Length - 2];
        }

        public static decimal GetThirdElementFromEnd(decimal[] array)
        {
            // Use index from end operator: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return array[^3];
        }

        public static decimal GetFourthElementFromEnd(decimal[] array)
        {
            // Use index from end operator: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/ranges-indexes
            return array[^4];
        }
    }
}
