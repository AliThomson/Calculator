namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter an operator: ");
            string operand = Console.ReadLine();
                        
            Console.WriteLine("enter a number: ");
            string firstString = Console.ReadLine();
            int firstNumber = int.Parse(firstString);

            Console.WriteLine("and another");
            string secondString = Console.ReadLine();
            int secondNumber = int.Parse(secondString);
            int sum = 0;

            if (operand == "+") 
            {
                sum = firstNumber + secondNumber;
            } else if ( operand == "-")
            {
                sum = firstNumber - secondNumber;
            } else if ( operand == "*")
            {
                sum = firstNumber * secondNumber;
            } else if ( operand == "/")
            {
                sum = firstNumber / secondNumber;
            } else
            {
                Console.WriteLine("Please enter a valid operand i.e. +, -. * or /");
            }
            if (sum != 0){
                Console.WriteLine("And the answer is: " + sum);
                Console.ReadLine();
            }
            
            
        }
    }
}
