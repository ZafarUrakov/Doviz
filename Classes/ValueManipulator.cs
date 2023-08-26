namespace Doviz.Classes;

public class ValueManipulator
{
    
    public static int FormatExceptionMessage()
    {

        int firstOption = 0;
        try
        {
            firstOption = int.Parse(Console.ReadLine());
        }
        catch (FormatException formatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The input is not in a correct format");
            Console.ResetColor();
        }
        catch (OverflowException overflowException)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Value is too large or too small, take a look data type.");
            Console.ResetColor();

        }
        catch (Exception exception)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(exception.Message);
            Console.ResetColor();

        }

        return firstOption;
    }
    
    public static double GetUserValueByMassage(string text)
    {
        Console.Write(text);
        return double.Parse(Console.ReadLine()!);
    }

    public static void ShowMessage(string message)
    {
        Console.Write(message);
    }
}