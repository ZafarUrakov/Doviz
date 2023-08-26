using Doviz.Interfaces;

namespace Doviz.Classes;

public class Report : IReport
{
    public void ShowMenu()
    {
        ValueManipulator.ShowMessage("1.Dollar -> Gold\n2.Gold -> Dollar" +
                                     "\n3.Exit\nChoice: ");
    }

    public void ReportProgress()
    {
        ValueManipulator.ShowMessage("\nConversion is in progress...");
    }
    
    public void Exit()
    {
        ValueManipulator.ShowMessage("Thank you for using application!");
    }
}