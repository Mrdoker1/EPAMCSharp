using System;

namespace GetNeighbors
{
    public static class CartesianCoordinates
    {
        /// <summary>
        /// Gets from a set of points only points that are h-neighbors for a point with integer coordinates x and y.
        /// </summary>
        /// <param name="point">Given point with integer coordinates x and y.</param>
        /// <param name="h">Distance around a given point.</param>
        /// <param name="points">A given set of points.</param>
        /// <returns>Only points that are h-neighbors for a point with integer coordinates x and y.</returns>
        /// <exception cref="ArgumentNullException">Throw when array points is null.</exception>
        /// <exception cref="ArgumentException">Throw when h-distance is less or equals zero.</exception>
        public static Point[] GetNeighbors(Point point, int h, params Point[] points)
        {
            if (points is null)
            {
                throw new ArgumentNullException(nameof(point), "Points cannot be equals null.");
            }

            if (h <= 0)
            {
                throw new ArgumentException("Range cannot be less or equals zero.");
            }

            int counter = 0;

            foreach (Point currentPoint in points)
            {
                if ((Math.Abs(currentPoint.X - point.X) <= h) &&
                    (Math.Abs(currentPoint.Y - point.Y) <= h))
                {
                    counter++;
                }
            }

            Point[] result = new Point[counter];
            counter = 0;

            foreach (Point currentPoint in points)
            {
                if ((Math.Abs(currentPoint.X - point.X) <= h) &&
                    (Math.Abs(currentPoint.Y - point.Y) <= h))
                {
                    result[counter++] = currentPoint;
                }
            }

            return result;
        }
    }
}