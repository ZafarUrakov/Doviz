using System;

namespace Doviz
{
    class Program
    {
        static void Main()
        {
            start:
            try
            {
                Console.WriteLine(@"
                1.Enter the application
                2.Exit");
                Console.Write("Choice: ");
                int userChoice = Convert.ToInt32(Console.ReadLine()!);

                while(userChoice == 1)
                {
                    Console.WriteLine(@"Want you consvert dollar to gold?
            Then you are at the right place!");
                    
                    Console.WriteLine(@"
    What do you want to convert?:
                    1. Gold -> Dollar
                    2. Dollar -> Gold
                    3. Exit");
                    Console.Write("Choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if(choice == 1 || choice == 2)
                    {
                        switch(choice)
                        {
                            case 1:
                                Console.Write("Enter Gold amount: ");
                                double gold = double.Parse(Console.ReadLine()!);

                                double convertToDollar = gold * 63;

                                Console.WriteLine("\tConversion is in progress...");
                                Console.WriteLine($"Dollar: {convertToDollar} $");
                                goto start;
                            case 2:
                                Console.Write("Enter Dollar amount: ");
                                double dollar = double.Parse(Console.ReadLine()!);

                                double convertToGold = dollar * 0.016;

                                Console.WriteLine("\tConversion is in progress...");
                                Console.WriteLine($"Gold: {convertToGold} gramm");
                                break;
                                default:
                                Console.WriteLine("You have the wrong answer!");
                                goto start;
                        }
                        goto start;
                    }
                    else 
                    {
                        Console.Write("Good Bye!");
                        goto start;
                    }
                }
            }
            catch(FormatException formatException)    
            {
                Console.WriteLine("\nLooks like the value you provided is not ingener.\n");
                goto start;
            }
            catch(OverflowException overFlowException)
            {
                Console.WriteLine("\nValue you provided was either to large or too small.\n");
                goto start;
            }
            catch(Exception exception)
            {
                Console.WriteLine("\nOops, something went wrong, contact support.\n");
                goto start;
            }
        }
    }
}