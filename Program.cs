using System;
using Doviz.Classes;
using Convert = System.Convert;

namespace Doviz
{
    class Program
    {
        static void Main()
        {
            var convert = new ConvertR();
            var report = new Report();
            report.ShowMenu();

            int userChoice = ValueManipulator.FormatExceptionMessage();
            if (userChoice == 1)
                convert.ConvertDollar();
            else if(userChoice == 2)
                convert.ConvertGold();
            else
                report.Exit();
        }
    }
}