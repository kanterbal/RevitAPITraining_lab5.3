using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RevitAPITraining_lab5._3
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Revit API Training";
            application.CreateRibbonTab(tabName);
            string utilsFolderPath = @"C:\Program Files\RevitAPITraining\";

            var panel = application.CreateRibbonPanel(tabName, "Задание 5.3");

            var button1 = new PushButtonData("Задание 5.1", "5.1",
                Path.Combine(utilsFolderPath, "RevitAPITraining_lab5.1.dll"),
                "RevitAPITraining_lab5._1.Main");

            Uri uriImage1 = new Uri(@"C:\Program Files\RevitAPITraining\Images\1.png", UriKind.Absolute);
            BitmapImage largeImage1 = new BitmapImage(uriImage1);
            button1.LargeImage = largeImage1;

            panel.AddItem(button1);

            var button2 = new PushButtonData("Задание 5.2", "5.2",
                Path.Combine(utilsFolderPath, "RevitAPITraining_lab5.2.dll"),
                "RevitAPITraining_lab5._2.Main");

            Uri uriImage2 = new Uri(@"C:\Program Files\RevitAPITraining\Images\2.png", UriKind.Absolute);
            BitmapImage largeImage2 = new BitmapImage(uriImage2);
            button2.LargeImage = largeImage2;

            panel.AddItem(button2);

            return Result.Succeeded;
        }
    }
}
