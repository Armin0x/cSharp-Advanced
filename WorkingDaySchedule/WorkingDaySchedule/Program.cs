using System;
using System.Collections.Generic;

namespace WorkingDaySchedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to working day schedule!");
            Console.Write("Please press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            bool runner;
            do
            {
                int year = UserInput("year");
                int month = UserInput("month");
                int day = UserInput("day");
                FreeDayChecker(year, month, day);
                runner = AppRunning();
            } while (runner);
        }
        public static bool AppRunning()
        {
            Console.WriteLine("Would you like to check a different day? Yes/No ");
            string input = Console.ReadLine().ToLower();
            if (input == "yes")
            {
                Console.Clear();
                return true;
            }
            Console.Clear();
            return false;
        }
        public static int UserInput(string dateFormat)
        {
            Console.Write($"Input {dateFormat}: ");
            return int.Parse(Console.ReadLine());
        }

        public static void FreeDayChecker(int year, int month, int day)
        {
            DateTime dateToCheck = new DateTime(year, month, day);
            bool notWorkingHoliday = false;
            bool notWorkingWeekend = false;
            foreach (var holiday in Holidays(year))
            {
                if (dateToCheck == holiday)
                {
                    notWorkingHoliday = true;
                }
                else if (dateToCheck.DayOfWeek.ToString() == "Saturday" ||
                         dateToCheck.DayOfWeek.ToString() == "Sunday")
                {
                    notWorkingWeekend = true;
                }
            }
            if (notWorkingHoliday)
            {
                Console.WriteLine("It's a holiday! You are free!");
            }
            else if (notWorkingWeekend)
            {
                Console.WriteLine("It's a weekend! You are free!");
            }
            else
            {
                Console.WriteLine("You are working.");
            }
        }
        public static List<DateTime> Holidays(int year)
        {
            return new List<DateTime>()
            {
                new DateTime(year, 1, 1),
                new DateTime(year, 1, 7),
                new DateTime(year, 4, 20),
                new DateTime(year, 5, 1),
                new DateTime(year, 5, 25),
                new DateTime(year, 8, 3),
                new DateTime(year, 9, 8),
                new DateTime(year, 10, 12),
                new DateTime(year, 10, 23),
                new DateTime(year, 12, 8),
            };
        }
    }

}