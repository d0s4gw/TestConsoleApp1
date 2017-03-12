using System;

namespace TestConsoleApp1
{
    class Program
    {
        public void run()
        {
            for (int i = 1; i <= 100; i++)
            {
               if (i % 15 == 0)
                {
                    Console.Out.WriteLine("FizzBuzz");
                } else if (i % 5 == 0)
                {
                    Console.Out.WriteLine("Buzz");
                } else if (i % 3 == 0)
                {
                    Console.Out.WriteLine("Fizz");
                } else
                {
                    Console.Out.WriteLine(i);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Starting application...");
            Program p = new Program();
            p.run();
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}