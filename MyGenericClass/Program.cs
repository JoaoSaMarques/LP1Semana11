using System;

namespace MyGenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> stringGuard = new Guarda3<string>();
            stringGuard.SetItem(0, "Hello");
            stringGuard.SetItem(1, "World");
            stringGuard.SetItem(2, "!");
            Console.WriteLine(stringGuard.GetItem(0));
            Console.WriteLine(stringGuard.GetItem(1));
            Console.WriteLine(stringGuard.GetItem(2));

            Guarda3<float> floatGuard = new Guarda3<float>();
            floatGuard.SetItem(0, 3.14f);
            floatGuard.SetItem(1, 2.718f);
            floatGuard.SetItem(2, 1.618f);
            Console.WriteLine(floatGuard.GetItem(0));
            Console.WriteLine(floatGuard.GetItem(1));
            Console.WriteLine(floatGuard.GetItem(2));
        }
    }
}
