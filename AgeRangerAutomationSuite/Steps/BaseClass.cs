using OpenQA.Selenium;
using System.Threading;

namespace AgeRangerWebUi.Steps
{
    public class BaseClass
    {
        public static IWebDriver Driver { get; set; }


        public static void Sleep(int milliSeconds)
        {
            Thread.Sleep(milliSeconds);
        }
    }
}
