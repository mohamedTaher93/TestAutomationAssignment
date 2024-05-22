using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Test_Automation_Assignment.Drivers;


namespace Test_Automation_Assignment.Hooks
{
    [Binding]
    public class Hooks : DriverInitialization
    {
        private static string dir = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string testResultPath = dir.Replace("bin\\Debug\\net6.0", "ScreenShots");

        [BeforeScenario]
        public void SetupDriver()
        {
            Console.WriteLine("Before .......");
            if (GetDriver() == null || GetDriver().ToString().ToLower().Contains("null"))
            {
                SetDriver();
            }

        }

        public static void TakeScreenShot()
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot)GetDriver();
            Screenshot screenshot = takesScreenshot.GetScreenshot();
            string screenshotLocation = Path.Combine(testResultPath, TestContext.CurrentContext.Test.MethodName + ".png");
            screenshot.SaveAsFile(screenshotLocation);

        }

        [AfterScenario]
        public void TeardownDriver()
        {

            TakeScreenShot();
            if (!GetDriver().Equals(null))
            {
                GetDriver().Quit();
            }
        }
    }
}
