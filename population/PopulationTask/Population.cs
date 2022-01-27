using System;

namespace PopulationTask
{
    public static class Population
    {
        /// <summary>
        /// Calculates the count of years which the town need to see its population greater or equal to currentPopulation inhabitants.
        /// </summary>
        /// <param name="initialPopulation">The population at the beginning of a year.</param>
        /// <param name="percent">The percentage of growth per year.</param>
        /// <param name="visitors">The visitors (new inhabitants per year) who come to live in the town.</param>
        /// <param name="currentPopulation">The population at present.</param>
        /// <returns>The count of years which the town need to see its population greater or equal to currentPopulation inhabitants.</returns>
        /// <exception cref="ArgumentException">
        /// Thrown when initial population is less or equals 0
        /// - or -
        /// the count of visitors cannot be less 0
        /// - or -
        /// the current population is less or equals 0
        /// - or -
        /// the current population is less than initial population.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">Throw if the value of percents is less then 0% or more then 100%.</exception>
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0)
            {
                throw new ArgumentException("initial population is less or equals 0", nameof(initialPopulation));
            }

            if (visitors < 0)
            {
                throw new ArgumentException("the count of visitors cannot be less 0", nameof(visitors));
            }

            if (currentPopulation <= 0)
            {
                throw new ArgumentException("Current population cannot be less or equals zero.");
            }

            if (currentPopulation < initialPopulation)
            {
                throw new ArgumentException("the current population is less than initial population.", nameof(currentPopulation));
            }

            if (percent < 0 || percent > 100d)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), $"{nameof(percent)} is out of range.");
            }

            double i = Convert.ToDouble(initialPopulation);
            int year = 0;

            do
            {
                i = i + (i * (percent / 100)) + visitors;
                year++;
            }
            while (i < currentPopulation);

            return year;
        }
    }
}