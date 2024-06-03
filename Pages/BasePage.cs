using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;

namespace Test_Automation_Assignment.Pages
{
    public class BasePage
    {
        public static WebDriverWait wait;
        private IWebDriver driver;
        private readonly string websiteUrl = "https://www.mbrhe.gov.ae/en/";
        private IJavaScriptExecutor js;

        public BasePage(IWebDriver driver) {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
        }
        public void LaunchWebsite()
        {

            driver.Navigate().GoToUrl(websiteUrl);
        }
        public void ClickElement(IWebDriver driver, By by)
        {
            IWebElement element = driver.FindElement(by);
            element.Click();
        }
        public void ClickElementByJs(IWebDriver driver, By by)
        {
            IWebElement element = driver.FindElement(by);
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            js.ExecuteScript("arguments[0].click();", element);
        }
        public void EnterText(IWebDriver driver, By by, String text)
        {
            IWebElement element = driver.FindElement(by);
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            element.SendKeys(text);
        }
        public void SelectFromDropDown(IWebDriver driver, By dropDownContainerBy, string option)
        {
            IWebElement dropDownElement = driver.FindElement(dropDownContainerBy);
            ClickElementByJs(driver, dropDownContainerBy);
            SelectElement selectElement = new SelectElement(dropDownElement);
            selectElement.SelectByText(option);
        }
        public String GetText(IWebDriver driver, By by)
        {
            IWebElement element = driver.FindElement(by);
            String elementText;
            elementText = element.Text;
            return elementText;
        }
        public void WaitForInvisibilityOfElement(By by)
        {
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(by));
        }
        public Boolean ElementDisplayed(IWebDriver driver, By by)
        {
            IList<IWebElement> elements = driver.FindElements(by);
            if (elements.Count == 0)
            {
                return false;
            }
            return true;
        }
        public void WaitForElement(By by)
        {
            wait.Until(ExpectedConditions.ElementExists(by));
        }
        public void ScrollToElement(IWebDriver driver, By by)
        {
            IWebElement element = driver.FindElement(by);
            js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }
        public void ScrollToElementAction(IWebDriver driver, By by)
        {
            IWebElement element = driver.FindElement(by);
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();
        }
    }
}
