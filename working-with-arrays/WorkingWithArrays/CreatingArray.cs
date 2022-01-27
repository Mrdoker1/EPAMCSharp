using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            int[] arr = Array.Empty<int>();

            return arr;
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            bool[] arr = Array.Empty<bool>();

            return arr;
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            string[] arr = Array.Empty<string>();

            return arr;
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            char[] arr = Array.Empty<char>();

            return arr;
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            double[] arr = Array.Empty<double>();

            return arr;
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            float[] arr = Array.Empty<float>();

            return arr;
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            decimal[] arr = Array.Empty<decimal>();

            return arr;
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            int[] arr = new int[10];

            return arr;
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            bool[] arr = new bool[20];

            return arr;
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            string[] arr = new string[5];

            return arr;
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            char[] arr = new char[15];

            return arr;
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            double[] arr = new double[18];

            return arr;
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            float[] arr = new float[100];

            return arr;
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            decimal[] arr = new decimal[1000];

            return arr;
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 123456 };

            return arr;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 1111111, 9999999 };

            return arr;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 0, 4234, 3845, 2942, 1104, 9794, 923943, 7537, 4162, 10134 };

            return arr;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { true };

            return arr;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { true, false, true, false, true };

            return arr;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { false, true, true, false, true, true, false };

            return arr;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { "one" };

            return arr;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { "one", "two", "three" };

            return arr;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { "one", "two", "three", "four", "five", "six" };

            return arr;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 'a' };

            return arr;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 'a', 'b', 'c' };

            return arr;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a' };

            return arr;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 1.12 };

            return arr;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 1.12, 2.23, 3.34, 4.45, 5.56 };

            return arr;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };

            return arr;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 123456789.123456f };

            return arr;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 1000000.123456f, 2223334444.123456f, 9999.999999f };

            return arr;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 1.0123f, 20.012345f, 300.01234567f, 4000.01234567f, 500000.01234567f };

            return arr;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 10000.123456m };

            return arr;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 1000.1234m, 100000.2345m, 100000.3456m, 1000000.456789m, 10000000.5678901m };

            return arr;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            var arr = new[] { 10.122112m, 200.233223m, 3000.344334m, 40000.455445m, 500000.566556m, 6000000.677667m, 70000000.788778m, 800000000.899889m, 9000000000.911991m };

            return arr;
        }
    }
}
