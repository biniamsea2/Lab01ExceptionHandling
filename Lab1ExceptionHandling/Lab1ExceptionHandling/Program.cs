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
            string answer = Console.ReadLine();
            int result = Convert.ToInt32(answer);
            int[] userArray = new int[result];

            Populate(userArray);
            GetSum(userArray);

         


        }
        private static int[] Populate(int[] userArray)
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1}/{userArray.Length}: ");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return userArray;
        }

        private static int GetSum(int[] sumArray)
        {
            int sum = 0;
            for (int i = 0; i < sumArray.Length; i++)
            {
     
                sum += sumArray[i];
            }
            if (sum < 20)
            {
                throw new Exception($"Value of {sum} is too low");

            }
            return sum;
        }


        private static int GetProduct(int[] userArray, int sum)
        {
            int product = 0;
            try
            {
            Console.WriteLine("Select a random number between 1 and {0} ", userArray.Length);
            string answer = Console.ReadLine();
            int temp = Convert.ToInt32(answer);

            product = sum * temp; 

            return product;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static decimal GetQutient(int product)
        {
            Console.WriteLine("Enter a number to divide the product by: ");
        }
    }
}
