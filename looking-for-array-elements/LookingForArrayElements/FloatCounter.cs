using System;

namespace LookingForArrayElements
{
    public static class FloatCounter
    {
        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("startRange and endRange length are different");
            }

            if (rangeStart.Length == 0)
            {
                return 0;
            }

            try
            {
                for (int i = 0; i < rangeStart.Length; i++)
                {
                    if (rangeStart[i] > rangeEnd[i])
                    {
                        throw new ArgumentException("rangeStart value greater than rangeEndValue");
                    }
                }
            }
            catch
            {
                throw new ArgumentException("rangeStart value greater than rangeEndValue");
            }

            int counter = 0;

            for (int i = 0; i < arrayToSearch.Length; i++)
            {
                for (int j = 0; j < rangeStart.Length; j++)
                {
                    if (arrayToSearch[i] >= rangeStart[j] && arrayToSearch[i] <= rangeEnd[j])
                    {
                        counter++;
                    }
                }
            }

            return counter;
        }

        /// <summary>
        /// Searches an array of floats for elements that are in a specified range, and returns the number of occurrences of the elements that matches the range criteria.
        /// </summary>
        /// <param name="arrayToSearch">One-dimensional, zero-based <see cref="Array"/> of single-precision floating-point numbers.</param>
        /// <param name="rangeStart">One-dimensional, zero-based <see cref="Array"/> of the range starts.</param>
        /// <param name="rangeEnd">One-dimensional, zero-based <see cref="Array"/> of the range ends.</param>
        /// <param name="startIndex">The zero-based starting index of the search.</param>
        /// <param name="count">The number of elements in the section to search.</param>
        /// <returns>The number of occurrences of the <see cref="Array"/> elements that match the range criteria.</returns>
        public static int GetFloatsCount(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (rangeStart is null)
            {
                throw new ArgumentNullException(nameof(rangeStart));
            }

            if (rangeEnd is null)
            {
                throw new ArgumentNullException(nameof(rangeEnd));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (count == 0 || rangeStart.Length == 0)
            {
                return 0;
            }

            if (rangeStart.Length != rangeEnd.Length)
            {
                throw new ArgumentException("startRange and endRange length are different");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            try
            {
                for (int i = 0; i < rangeStart.Length; i++)
                {
                    if (rangeStart[i] > rangeEnd[i])
                    {
                        throw new ArgumentException("rangeStart value greater than rangeEndValue");
                    }
                }
            }
            catch
            {
                throw new ArgumentException("rangeStart value greater than rangeEndValue");
            }

            int lastIndex = startIndex + count;
            int range = rangeStart.Length - 1;
            int counter = 0;

            if (lastIndex == -1)
            {
                return 0;
            }

            do
            {
                do
                {
                    if (arrayToSearch[startIndex] >= rangeStart[range] && arrayToSearch[startIndex] <= rangeEnd[range])
                    {
                        counter++;
                    }
                }
                while (--range >= 0);

                range = rangeStart.Length - 1;
            }
            while (++startIndex < lastIndex);

            return counter;
        }
    }
}
