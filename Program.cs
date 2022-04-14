using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter an operator: ");
            string operand = Console.ReadLine();

            Console.WriteLine("how many numbers do you want to {0}: ", operand);
            string userSize = Console.ReadLine();
            int arraySize = int.Parse(userSize);

            int[] numbers = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine("enter number {0}: ", i+1);
                string userNo = Console.ReadLine();
                numbers[i] = int.Parse(userNo);
            }
                        
            int sum = numbers[0];
            for (int i = 1; i < arraySize; i++)
            {
                if (operand == "+") 
                {
                    sum = sum + numbers[i];
                }
                else if ( operand == "-")
                {
                    sum = sum - numbers[i];
                }
                else if ( operand == "*")
                {
                    sum = sum * numbers[i];
                }
                else if ( operand == "/")
                {
                    sum = sum / numbers[i];
                }
                else
                {
                    Console.WriteLine("Please enter a valid operand i.e. +, -. * or /");
                }
            }
            if (sum != 0){
                Console.WriteLine("And the answer is: " + sum);
            }
        }
    }
}
