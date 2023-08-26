using Doviz.Interfaces;

namespace Doviz.Classes;

public class ConvertR : IConvertR
{
    private double Bucks { get; set; }
    private double Gold { get; set; }
    
    public void ConvertDollar()
    {
        Console.Clear();
        ValueManipulator.ShowMessage("So mate, how many bucks do you have?");
        Bucks = ValueManipulator.GetUserValueByMassage("\nI have ");

        double convertToGold = Bucks * 0.016;
        var report = new Report();
        report.ReportProgress();
        if(convertToGold < 1000)
            ValueManipulator.ShowMessage($"\n\nHere is your {convertToGold} grams of gold, dude.");
        else
            ValueManipulator.ShowMessage($"\n\nHere is your {convertToGold} kilos of gold, dude.");
    }

    public void ConvertGold()
    {
        Console.Clear();
        ValueManipulator.ShowMessage("So mate, how much gold do you have?");
        Gold = ValueManipulator.GetUserValueByMassage("\nI have ");

        double convertToBucks = Gold * 63;
        var report = new Report();
        report.ReportProgress();

        ValueManipulator.ShowMessage($"\n\nHere is your {convertToBucks} bucks, dude.");
    }
}