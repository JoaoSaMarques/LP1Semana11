using System;
using System.Collections.Generic;

namespace BeforeUtils
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int> { 1, 3, 5, 7, 9 };
            int pivot = 6;
            var result = BeforeUtils.GetTheOnesBefore(numbers, pivot);
            Console.WriteLine($"Numbers before {pivot}:");
            foreach (var number in result)
            {
                Console.WriteLine(number);
            }

            var dates = new List<DateTime>
            {
                new DateTime(2022, 1, 1),
                new DateTime(2022, 2, 1),
                new DateTime(2022, 3, 1),
                new DateTime(2022, 4, 1),
                new DateTime(2022, 5, 1)
            };
            var pivotDate = new DateTime(2022, 3, 15);
            var resultDates = BeforeUtils.GetTheOnesBefore(dates, pivotDate);
            Console.WriteLine($"Dates before {pivotDate}:");
            foreach (var date in resultDates)
            {
                Console.WriteLine(date);
            }
        }
    }
}
