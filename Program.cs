namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number: ");
            string firstString = Console.ReadLine();
            int firstNumber = int.Parse(firstString);
            Console.WriteLine("and another");
            string secondString = Console.ReadLine();
            int secondNumber = int.Parse(secondString);
            int product = firstNumber * secondNumber;
            Console.WriteLine("And the answer is: " + product);
            Console.ReadLine();
        }
    }
}
