using System;

namespace AgeChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 65)
            {
                Console.WriteLine("Your ticket price is £4!");
            }
            else if (age <= 18)
            {
                Console.WriteLine("Your ticket price is £4.50!");
            }
            else
            {
                Console.WriteLine("Your ticket price £6.50");
            }

        }
    }
}
