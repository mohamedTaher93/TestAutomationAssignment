using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace Test_Automation_Assignment.Drivers
{
    public class DriverInitialization
    {
        private static IWebDriver driver;

        public static void SetDriver()
        {
            Console.WriteLine("Setup driver....");

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver(ChromeOptions());
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }
        public static IWebDriver GetDriver()
        {
            return driver;
        }
        private static ChromeOptions ChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("no-sandbox");
            options.AddArguments("--start-maximized");
            return options;
        }
    }
}
