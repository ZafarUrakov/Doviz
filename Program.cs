using System;

namespace Doviz
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"Want you consvert dollar to gold?
                Then you are at the right place!");
            
            Console.WriteLine(@"What do you want to convert?:
            1. Gold -> Dollar
            2. Dollar -> Gold");
            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Console.Write("Enter Gold amount: ");
                double gold = double.Parse(Console.ReadLine()!);

                double convertToGold = gold * 63;

                Console.WriteLine("\tConversion is in progress...");
                Console.WriteLine($"Dollar: {convertToGold} $");
            }
            else if(choice == 2)
            {
                Console.Write("Enter Dollar amount: ");
                double dollar = double.Parse(Console.ReadLine()!);

                double convertToGold = dollar * 0.016;

                Console.WriteLine("\tConversion is in progress...");
                Console.WriteLine($"Gold: {convertToGold} gramm");
            }
            else
            {
                Console.WriteLine("You have the wrong answer!");
            }
                //Switch
            Console.WriteLine("\nVersion with Switch\n");

            switch(choice)
            {
                case 1:
                    Console.Write("Enter Gold amount: ");
                    double gold = double.Parse(Console.ReadLine()!);

                    double convertToDollar = gold * 63;

                    Console.WriteLine("\tConversion is in progress...");
                    Console.WriteLine($"Dollar: {convertToDollar} $");

                    Console.WriteLine("\nEnter the word \"dotnet run\" to convert again.");
                    break;
                case 2:
                    Console.Write("Enter Dollar amount: ");
                    double dollar = double.Parse(Console.ReadLine()!);

                    double convertToGold = dollar * 0.016;

                    Console.WriteLine("\tConversion is in progress...");
                    Console.WriteLine($"Gold: {convertToGold} gramm");

                    Console.WriteLine("\nEnter the word \"dotnet run\" to convert again.");
                    break;
                default:
                    Console.WriteLine("You have the wrong answer!");
                    Console.WriteLine("Enter \"dotnet run\" to try again");
                    break;
            }
        }
    }
}