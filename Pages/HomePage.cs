using OpenQA.Selenium;
using TestAutomationAssignment.ObjRepo;

namespace Test_Automation_Assignment.Pages
{
    public class HomePage : BasePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void SwitchToEnglishLanguage()
        {
            base.WaitForElement(HomeLocators.homePopUpBy);
            base.ClickElement(driver, HomeLocators.closePopUpBy);
            base.WaitForInvisibilityOfElement(HomeLocators.homePopUpBy);
            base.ClickElement(driver, HomeLocators.switchToEnglishBtnBy);
            base.WaitForElement(HomeLocators.homePopUpBy);
            base.ClickElement(driver, HomeLocators.closePopUpBy);
            base.WaitForInvisibilityOfElement(HomeLocators.homePopUpBy);
        }
        public void NavigateToContactUsPage()
        {
            base.ClickElement(driver, HomeLocators.contactUsBtnBy);
        }
    }
}
