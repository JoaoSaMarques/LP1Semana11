using System;

namespace MyEnumerable
{
    class Program
    {
        static void Main()
        {
            Guarda3<string> stringGuard = new Guarda3<string>();
            stringGuard.SetItem(0, "Hello");
            stringGuard.SetItem(1, "World");
            stringGuard.SetItem(2, "!");

            foreach (var item in stringGuard)
            {
                Console.WriteLine(item);
            }

            Guarda3<float> floatGuard = new Guarda3<float>();
            floatGuard.SetItem(0, 3.14f);
            floatGuard.SetItem(1, 2.718f);
            floatGuard.SetItem(2, 1.618f);

            foreach (var item in floatGuard)
            {
                Console.WriteLine(item);
            }
        }
    }
}
