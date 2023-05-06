using System;


namespace Pr_Task1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine((i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "") + (i % 3 != 0 && i % 5 != 0 ? i.ToString() : ""));
            }
            Console.ReadKey();
        }
    }
}
