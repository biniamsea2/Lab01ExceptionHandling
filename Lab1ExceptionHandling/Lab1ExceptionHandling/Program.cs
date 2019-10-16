using System;

namespace Lab1ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Numbers Game");
            try
            {
            StartSequence();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("The program is completed");
            }
        }


        private static void StartSequence()
        {
            try
            {
            Console.WriteLine("Enter a number greater than zero");
            string answer = Console.ReadLine();
            int result = Convert.ToInt32(answer);
            int[] userArray = new int[result];
            int[] secondArray = Populate(userArray);
            int sum = GetSum(secondArray);
            int product = GetProduct(secondArray, sum);
            decimal finial = GetQuotient(product);


            Console.WriteLine($"You array size is: {secondArray.Length}");
            Console.WriteLine($"The numbers in the array are " + string.Join(",",userArray) + "");
                Console.WriteLine($"The sum of your array is {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");
                Console.WriteLine($"{product} / {product / finial} = {finial}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
               
            }

            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);

            }

            catch (Exception)
            {
                throw;
            }

        }
        private static int[] Populate(int[] userArray)
        {
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1}/{userArray.Length}: ");
                string answer = Console.ReadLine();
                userArray[i] = Convert.ToInt32(answer);
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
            try
            {
            Console.WriteLine("Select a random number between 1 and {0} ", userArray.Length);
            string answer = Console.ReadLine();
            int temp = Convert.ToInt32(answer);

            int product = userArray[temp - 1] * sum; 

            return product;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private static decimal GetQuotient(int product)
        {
            try
            {
            Console.WriteLine($"Enter a number to divide {product} by: ");
            string answer = Console.ReadLine();
            int result = Convert.ToInt32(answer);

            decimal final = decimal.Divide(product, result);

            return final;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
