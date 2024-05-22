using System;
using System.Collections.Generic;

namespace HowManyOfThisType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> objects = new List<object> {1, "test", 2, 3.5, 4};
            int count = Checker.HowManyOfType<int>(objects);
            Console.WriteLine($"Number of integers: {count}");
        }
    }
}
