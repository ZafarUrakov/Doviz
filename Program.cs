Console.WriteLine(@"Want you consvert dollar to gold?
    Then you are at the right place!");

Console.Write("Enter dollar amount: ");
var money = double.Parse(Console.ReadLine()!);

double convertToGold = money * 0.016;

Console.WriteLine("\tConversion is in progress...");
Console.WriteLine($"Gold: {convertToGold} gramm");

Console.WriteLine("\nEnetr the word \"dotnet run\" to convert again.");