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
            // Close the popup form if displayed
            CancelPopUpIfDisplayed();
            base.WaitForInvisibilityOfElement(HomeLocators.homePopUpBy);
            base.ClickElement(driver, HomeLocators.switchToEnglishBtnBy);
            // Close the popup form if displayed
            CancelPopUpIfDisplayed();
            base.WaitForInvisibilityOfElement(HomeLocators.homePopUpBy);
        }
        public void NavigateToContactUsPage()
        {
            base.ClickElement(driver, HomeLocators.contactUsBtnBy);
        }
        public void CancelPopUpIfDisplayed()
        {
            try
            {
                base.ClickElement(driver, HomeLocators.closePopUpBy);
            }
            catch 
            { 
                // Continue because the popup not displayed
            }
        }
    }
}
