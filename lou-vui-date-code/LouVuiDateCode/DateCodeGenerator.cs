using System;
using System.Globalization;

namespace LouVuiDateCode
{
    public static class DateCodeGenerator
    {
        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingYear < 1980 || manufacturingYear > 1989)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear), "Wrong Year!");
            }

            if (manufacturingMonth > 12 || manufacturingMonth < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth), "Wrong Month!");
            }

            double x = manufacturingYear % 100;
            return string.Concat(x.ToString(new CultureInfo("en-US")), manufacturingMonth.ToString(new CultureInfo("en-US")));
        }

        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(DateTime manufacturingDate)
        {
            if (manufacturingDate.Year < 1980 || manufacturingDate.Year > 1989)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate), "Wrong Year!");
            }

            if (manufacturingDate.Month > 12 || manufacturingDate.Month < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate), "Wrong Month!");
            }

            double x = manufacturingDate.Year % 100;
            return string.Concat(x.ToString(new CultureInfo("en-US")), manufacturingDate.Month.ToString(new CultureInfo("en-US")));
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(factoryLocationCode);
            }
            else
            {
                factoryLocationCode = factoryLocationCode.ToUpper(new CultureInfo("en-US"));
            }

            if (manufacturingYear < 1980 || manufacturingYear > 1989)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear), "Wrong Year!");
            }

            if (manufacturingMonth > 12 || manufacturingMonth < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth), "Wrong Month!");
            }

            if (!CountryCodeCheck(factoryLocationCode))
            {
                throw new ArgumentException(factoryLocationCode);
            }

            double x = manufacturingYear % 100;
            return string.Concat(x.ToString(new CultureInfo("en-US")), manufacturingMonth.ToString(new CultureInfo("en-US")), factoryLocationCode);
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(factoryLocationCode);
            }
            else
            {
                factoryLocationCode = factoryLocationCode.ToUpper(new CultureInfo("en-US"));
            }

            if (manufacturingDate.Year < 1980 || manufacturingDate.Year > 1989)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate), "Wrong Year!");
            }

            if (manufacturingDate.Month > 12 || manufacturingDate.Month < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate), "Wrong Month!");
            }

            if (!CountryCodeCheck(factoryLocationCode))
            {
                throw new ArgumentException(factoryLocationCode);
            }

            double x = manufacturingDate.Year % 100;
            return string.Concat(x.ToString(new CultureInfo("en-US")), manufacturingDate.Month.ToString(new CultureInfo("en-US")), factoryLocationCode);
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(factoryLocationCode);
            }
            else
            {
                factoryLocationCode = factoryLocationCode.ToUpper(new CultureInfo("en-US"));
            }

            if (manufacturingYear < 1990 || manufacturingYear > 2006)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear), "Wrong Year!");
            }

            if (manufacturingMonth > 12 || manufacturingMonth < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth), "Wrong Month!");
            }

            if (!CountryCodeCheck(factoryLocationCode))
            {
                throw new ArgumentException(factoryLocationCode);
            }

            string month = manufacturingMonth.ToString("D2", new CultureInfo("en-US"));
            string year = (manufacturingYear % 100).ToString("D2", new CultureInfo("en-US"));

            return string.Concat(factoryLocationCode, month.Substring(0, 1), year.Substring(0, 1), month.Substring(1), year.Substring(1));
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(factoryLocationCode);
            }
            else
            {
                factoryLocationCode = factoryLocationCode.ToUpper(new CultureInfo("en-US"));
            }

            if (manufacturingDate.Year < 1990 || manufacturingDate.Year > 2006)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate), "Wrong Year!");
            }

            if (manufacturingDate.Month > 12 || manufacturingDate.Month < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate), "Wrong Month!");
            }

            if (!CountryCodeCheck(factoryLocationCode))
            {
                throw new ArgumentException(factoryLocationCode);
            }

            string month = manufacturingDate.Month.ToString("D2", new CultureInfo("en-US"));
            string year = (manufacturingDate.Year % 100).ToString("D2", new CultureInfo("en-US"));

            return string.Concat(factoryLocationCode, month.Substring(0, 1), year.Substring(0, 1), month.Substring(1), year.Substring(1));
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingWeek">A manufacturing week number.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingWeek)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(factoryLocationCode);
            }
            else
            {
                factoryLocationCode = factoryLocationCode.ToUpper(new CultureInfo("en-US"));
            }

            if (manufacturingYear < 2007)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear), "Wrong Year!");
            }

            DateTime endOfMonth = new DateTime((int)manufacturingYear, 12, 1).AddMonths(1).AddDays(-1);

            if (manufacturingWeek > GetWeek(endOfMonth.ToUniversalTime()) || manufacturingWeek < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingWeek), "Wrong Week!");
            }

            if (!CountryCodeCheck(factoryLocationCode))
            {
                throw new ArgumentException(factoryLocationCode);
            }

            string week = manufacturingWeek.ToString("D2", new CultureInfo("en-US"));
            string year = (manufacturingYear % 100).ToString("D2", new CultureInfo("en-US"));

            return string.Concat(factoryLocationCode, week.Substring(0, 1), year.Substring(0, 1), week.Substring(1), year.Substring(1));
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            CultureInfo myCI = new CultureInfo("en-US");
            //manufacturingDate = manufacturingDate.ToUniversalTime();

            if (!CountryCodeCheck(factoryLocationCode))
            {
                throw new ArgumentException(factoryLocationCode);
            }

            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(factoryLocationCode);
            }
            else
            {
                factoryLocationCode = factoryLocationCode.ToUpper(new CultureInfo("en-US"));
            }

            if (manufacturingDate.Year < 2007)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate), "Wrong Year!");
            }

            DateTime endOfMonth = new DateTime(manufacturingDate.Year, 12, 1).AddMonths(1).AddDays(-1);

            if (GetWeek(manufacturingDate) > 53 || GetWeek(manufacturingDate) < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate), "Wrong Week!");
            }

            string week = GetWeek(manufacturingDate).ToString("D2", myCI);

            string year = (manufacturingDate.Year % 100).ToString("D2", myCI);

            return string.Concat(factoryLocationCode, week.Substring(0, 1), year.Substring(0, 1), week.Substring(1), year.Substring(1));
        }

        public static bool CountryCodeCheck(string factoryLocationCode)
        {
            if (string.IsNullOrEmpty(factoryLocationCode))
            {
                throw new ArgumentNullException(factoryLocationCode);
            }
            else
            {
                factoryLocationCode = factoryLocationCode.ToUpper(new CultureInfo("en-US"));
            }

            if (Enum.IsDefined(typeof(France), factoryLocationCode.ToUpper(new CultureInfo("en-US")))
                || Enum.IsDefined(typeof(Germany), factoryLocationCode.ToUpper(new CultureInfo("en-US")))
                || Enum.IsDefined(typeof(Italy), factoryLocationCode.ToUpper(new CultureInfo("en-US")))
                || Enum.IsDefined(typeof(Spain), factoryLocationCode.ToUpper(new CultureInfo("en-US")))
                || Enum.IsDefined(typeof(Switzerland), factoryLocationCode.ToUpper(new CultureInfo("en-US")))
                || Enum.IsDefined(typeof(USA), factoryLocationCode.ToUpper(new CultureInfo("en-US"))))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetWeek(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
