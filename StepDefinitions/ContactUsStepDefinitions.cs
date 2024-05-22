using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Test_Automation_Assignment.Drivers;
using Test_Automation_Assignment.Pages;

namespace Test_Automation_Assignment.StepDefinitions
{
    [Binding]
    public sealed class ContactUsStepDefinitions
    {
        private static IWebDriver driver = DriverInitialization.GetDriver();
        BasePage basePage = new BasePage(driver);
        HomePage homePage = new HomePage(driver);
        ContactUsPage contactUsPage = new ContactUsPage(driver);

        [Given("I Navigate To Website")]
        public void NavigateToWebsite()
        {
            basePage.LaunchWebsite();
        }

        [Given("I Change Website Language To English")]
        public void GivenChangeLanguageToEnglish()
        {
            homePage.SwitchToEnglishLanguage();
        }

        [When("I Navigate To Contact Us Button On Home Page")]
        public void WhenNavigateToContactUsOnHomePage()
        {
            homePage.NavigateToContactUsPage();
            contactUsPage.CheckContactUsPageOpened();
        }
        
        [When("I Enter (.*) In Full Name Field")]
        public void WhenEnterName(String fullName)
        {
            contactUsPage.EnterFullName(fullName);
        }
        [When("I Enter (.*) In Mobile Number Field")]
        public void WhenEnterMobileNumber(string mobileNumber)
        {
            contactUsPage.EnterMobileNumber(mobileNumber);
        }
        [When("I Enter (.*) In Email Address Field")]
        public void WhenEnterEmailAddress(string emailAddress)
        {
            contactUsPage.EnterEmail(emailAddress);
        }
        [When("I Enter (.*) In Subject Field")]
        public void WhenEnterSubject(string subject)
        {
            contactUsPage.EnterSubject(subject);
        }
        [When("I Select (.*) Option From Call You DropDown")]
        public void WhenSelectCallYouOption(string option)
        {
            contactUsPage.SelectCustomerServicesOption(option);
        }
        [When("I Select (.*) From Category DropDown")]
        public void WhenSelectCategory(string category)
        {
            contactUsPage.SelectCategory(category);
        }
        [When("I Select (.*) Of The Inquiry")]
        public void WhenSelectInquiryType(string type)
        {
            contactUsPage.SelectType(type);
        }
        [When("I Enter (.*) In Message field")]
        public void WhenEnterMessage(string message)
        {
            contactUsPage.EnterMessage(message);
        }
        [When("Click On Submit Button")]
        public void ThenClickSubmitButton()
        {
            contactUsPage.ClickSubmitButton();
        }
        [Then("Verify Security Code Is Required Error Message Displayed Correctly")]
        public void ThenVerifySecurityCodeRequiredErrMsgDisplayedCorrectly()
        {
            contactUsPage.VerifySecCodeMsgDisplayedCorrectly();
        }
    }
}
