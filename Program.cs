using System;
namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            
            Console.WriteLine("Where do you live?");
            string city = Console.ReadLine();

            DisplayResults(
                ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city)
            );
        }
        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
            
        }
        private static void DisplayResults(
            string revFirstName, 
            string revLastName, 
            string revCity)
        {
            Console.Write(String.Format("{0} {1} {2}", 
                revFirstName, 
                revLastName, 
                revCity));
        }
    }
}
