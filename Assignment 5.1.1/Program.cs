using System.Linq.Expressions;

namespace Assignment_5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 323;
            int number1 = 3243;
            int number2 = -323;

            Console.WriteLine(isPalindrome(number));
            Console.WriteLine(isPalindrome(number1));
            Console.WriteLine(isPalindrome(number2));
        }
        static bool isPalindrome(int number) 
        {
            // If number is negative then return false. Negative numbers cannot be palindromes
            if (number < 0) { return false; }

            int numberReversed = 0;
            int originalNumber = number;

            while (number > 0) 
            {
                // Get the next integer element in the number
                int numberElement = number % 10;

                // Remove that integer from number and add it to numberReversed
                number /= 10;

                numberReversed *= 10;
                numberReversed += numberElement;
            }
            // Compare number reversed to original number
            if (numberReversed == originalNumber)
            {
                return true;
            }
            else { return false; }
        }
    }
}
