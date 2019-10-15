using System;

namespace Lab1ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }

        private static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero");
            int result = int.Parse(Console.ReadLine());
        }

    }
}
