using System;
using System.Globalization;

namespace SelectionStatments
{
    public static class Statements
    {
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            try
            {
                if (first > second && first > third)
                {
                    Console.WriteLine("Number " + first + " is the largest\n");
                }
                else
                {
                    if (second > first && second > third)
                    {
                        Console.WriteLine("Number " + second + " is the largest\n");
                    }
                    else
                    {
                        if (third > first && third > second)
                        {
                            Console.WriteLine("Number " + third + " is the largest\n");
                        }
                    }
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            try
            {
                int result = first > second && first > third ? first : second > first && second > third ? second : third;
                Console.WriteLine("Number " + result + " is the largest\n");
            }
            catch
            {
                throw new NotImplementedException();    
            }
        }

        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (first > second && first > third)
            {
                Console.WriteLine("Number " + first + " is the largest\n");
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("Number " + second + " is the largest\n");
            }
            else if (third > first && third > second)
            {
                Console.WriteLine("Number " + third + " is the largest\n");
            }
        }

        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            try
            {
                if (userAge >= 65)
                {
                    Console.WriteLine("Enjoy your retirement!");
                    return;
                }
                else if (userAge >= 21)
                {
                    Console.WriteLine("Fancy an alcoholic beverage?");
                    return;
                }
                else if (userAge >= 18)
                {
                    Console.WriteLine("You're old enough to drive.");
                    return;
                }
                else
                {
                    Console.WriteLine("You are too young to drive, drink, or retire.");
                    return;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            try
            {
                if (countOfDailyDownloads <= 0)
                {
                    Console.WriteLine("No downloads.");
                }
                else if (countOfDailyDownloads < 100)
                {
                    Console.WriteLine("Daily downloads: 1-100.");
                }
                else if (countOfDailyDownloads < 1000)
                {
                    Console.WriteLine("Daily downloads: 100-1,000.");
                }
                else if (countOfDailyDownloads < 10000)
                {
                    Console.WriteLine("Daily downloads: 1,000-10,000.");
                }
                else if (countOfDailyDownloads < 100000)
                {
                    Console.WriteLine("Daily downloads: 10,000-100,000.");
                }
                else
                {
                    Console.WriteLine("Daily downloads: 100,000+.");
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        
        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            try
            {
                if (dayOfWeek == DayOfWeek.Monday)
                {
                    Console.WriteLine("The first day of the work week.");
                }
                else if (dayOfWeek == DayOfWeek.Friday)
                {
                    Console.WriteLine("The last day of the work week.");
                }
                else if (dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Tuesday || dayOfWeek == DayOfWeek.Thursday)
                {
                    Console.WriteLine("The middle of the work week.");
                }
                else if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("The weekend.");
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            try
            {
                switch (dayOfWeek)
                {
                    case DayOfWeek.Monday:
                        Console.WriteLine("The first day of the work week.");
                        break;
                    case DayOfWeek.Friday:
                        Console.WriteLine("The last day of the work week.");
                        break;
                    case DayOfWeek.Wednesday:
                    case DayOfWeek.Tuesday:
                    case DayOfWeek.Thursday:
                        Console.WriteLine("The middle of the work week.");
                        break;
                    case DayOfWeek.Saturday:
                    case DayOfWeek.Sunday:
                        Console.WriteLine("The weekend.");
                        break;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            try
            {
                if (arg is sbyte)
                {
                    return arg + " is sbyte.";
                }
                else if (arg is byte)
                {
                    return arg + " is byte.";
                }
                else if (arg is short)
                {
                    return arg + " is short.";
                }
                else if (arg is int)
                {
                    return arg + " is int.";
                }
                else if (arg is long)
                {
                    return arg + " is long.";
                }
                else if (arg is ushort)
                {
                    return arg + " is ushort.";
                }
                else if (arg is uint)
                {
                    return arg + " is uint.";
                }
                else if (arg is ulong)
                {
                    return arg + " is ulong.";
                }
                else
                {
                    return arg + " is not integer.";
                }
            }
            catch
            {
                throw new NotImplementedException();
            }            
        }

        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            try
            {
                if (arg is null)
                {
                    throw new ArgumentNullException(nameof(arg));
                }

                switch (arg.GetType().Name)
                {
                    case "SByte":
                        return arg + " is sbyte.";
                    case "Byte":
                        return arg + " is byte.";
                    case "Int16":
                        return arg + " is short.";
                    case "Int32":
                        return arg + " is int.";
                    case "Int64":
                        return arg + " is long.";
                    case "UInt16":
                        return arg + " is ushort.";
                    case "UInt32":
                        return arg + " is uint.";
                    case "UInt64":
                        return arg + " is ulong.";
                    default:
                        return arg + " is not integer.";
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static string GetTypeOfIntegerWithSwitchExpression(object arg)
        {
            try
            {
                if (arg is null)
                {
                    throw new ArgumentNullException(nameof(arg));
                }

                return arg.GetType().Name switch
                {
                    "SByte" => arg + " is sbyte.",
                    "Byte" => arg + " is byte.",
                    "Int16" => arg + " is short.",
                    "Int32" => arg + " is int.",
                    "Int64" => arg + " is long.",
                    "UInt16" => arg + " is ushort.",
                    "UInt32" => arg + " is uint.",
                    "UInt64" => arg + " is ulong.",
                    _ => arg + " is not integer."

                };
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            try
            {
                switch (month)
                {
                    case Month.December:
                    case Month.January:
                    case Month.February:
                        Console.WriteLine("It's winter now.");
                        break;
                    case Month.March:
                    case Month.April:
                    case Month.May:
                        Console.WriteLine("It's spring now.");
                        break;
                    case Month.June:
                    case Month.July:
                    case Month.August:
                        Console.WriteLine("It's summer now.");
                        break;
                    case Month.September:
                    case Month.October:
                    case Month.November:
                        Console.WriteLine("It's autumn now.");
                        break;
                    default:
                        Console.WriteLine("Sorry, the month was entered incorrectly.");
                        break;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static byte GetLengthWithCascadedIfElse(int number)
        {
            CultureInfo format = new CultureInfo("en-EN");

            try
            {
                if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 1)
                {
                    return 1;
                }
                else if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 2)
                {
                    return 2;
                }
                else if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 3)
                {
                    return 3;
                }
                else if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 4)
                {
                    return 4;
                }
                else if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 5)
                {
                    return 5;
                }
                else if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 6)
                {
                    return 6;
                }
                else if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 7)
                {
                    return 7;
                }
                else if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 8)
                {
                    return 8;
                }
                else if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 9)
                {
                    return 9;
                }
                else if (Math.Abs(Convert.ToInt64(number)).ToString(format).Length == 10)
                {
                    return 10;
                }
                else
                {
                    return 1;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static byte GetLengthWithSwitchExpression(int number)
        {
            CultureInfo format = new CultureInfo("en-EN");

            try
            {
                return (byte)Math.Abs(Convert.ToInt64(number)).ToString(format).Length switch
                {
                    1 => 1,
                    2 => 2,
                    3 => 3,
                    4 => 4,
                    5 => 5,
                    6 => 6,
                    7 => 7,
                    8 => 8,
                    9 => 9,
                    10 => 10,
                    _ => 0

                };
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        
        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            try
            {
                if (month == 1)
                {
                    return Month.January;
                }
                else if (month == 2)
                {
                    return Month.February;
                }
                else if (month == 3)
                {
                    return Month.March;
                }
                else if (month == 4)
                {
                    return Month.April;
                }
                else if (month == 5)
                {
                    return Month.May;
                }
                else if (month == 6)
                {
                    return Month.June;
                }
                else if (month == 7)
                {
                    return Month.July;
                }
                else if (month == 8)
                {
                    return Month.August;
                }
                else if (month == 9)
                {
                    return Month.September;
                }
                else if (month == 10)
                {
                    return Month.October;
                }
                else if (month == 11)
                {
                    return Month.November;
                }
                else if (month == 12)
                {
                    return Month.December;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static Month? GetMonthWithSwitchStatement(int month)
        {
            try
            {
                switch (month)
                    {
                    case 1:
                        return Month.January;
                    case 2:
                        return Month.February;
                    case 3:
                        return Month.March;
                    case 4:
                        return Month.April;
                    case 5:
                        return Month.May;
                    case 6:
                        return Month.June;
                    case 7:
                        return Month.July;
                    case 8:
                        return Month.August;
                    case 9:
                        return Month.September;
                    case 10:
                        return Month.October;
                    case 11:
                        return Month.November;
                    case 12:
                        return Month.December;
                    default:
                        return null;
                }
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
        
        public static Month? GetMonthWithSwitchExpression(int month)
        {
            try
            {
                return month switch
                {
                    1 => Month.January,
                    2 => Month.February,
                    3 => Month.March,
                    4 => Month.April,
                    5 => Month.May,
                    6 => Month.June,
                    7 => Month.July,
                    8 => Month.August,
                    9 => Month.September,
                    10 => Month.October,
                    11 => Month.November,
                    12 => Month.December,
                    _ => null
                };
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}