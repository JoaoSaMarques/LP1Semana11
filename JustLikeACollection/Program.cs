using System;

namespace JustLikeACollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Guarda3<string> stringGuard = new Guarda3<string>
            {
                { "Hello" },
                { "World" },
                { "!" }
            };

            foreach (var item in stringGuard)
            {
                Console.WriteLine(item);
            }

            Guarda3<float> floatGuard = new Guarda3<float>
            {
                { 3.14f },
                { 2.718f },
                { 1.618f }
            };

            foreach (var item in floatGuard)
            {
                Console.WriteLine(item);
            }
        }
    }
}
