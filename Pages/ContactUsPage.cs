using OpenQA.Selenium;
using NUnit.Framework;
using TestAutomationAssignment.ObjRepo;

namespace Test_Automation_Assignment.Pages
{
    public class ContactUsPage : BasePage
    {
        private IWebDriver driver;
        public ContactUsPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        //Data
        private readonly string expectedSecurityErrTxt = "Security Code is Required";


        public void CheckContactUsPageOpened()
        {
            Assert.True(base.ElementDisplayed(driver, ContactUsLocators.contactUsHeader), "Contact us page not opened correctly");
        }
        public void EnterFullName(String fullName)
        {
            base.ScrollToElement(driver, ContactUsLocators.fullNameInputBy);
            base.EnterText(driver, ContactUsLocators.fullNameInputBy, fullName);
        }
        public void EnterMobileNumber(String mobileNumber)
        {
            base.ScrollToElement(driver, ContactUsLocators.mobileNumberInputBy);
            base.EnterText(driver, ContactUsLocators.mobileNumberInputBy, mobileNumber);
        }
        public void EnterSubject(String subject)
        {
            base.ScrollToElement(driver, ContactUsLocators.subjectInputBy);
            base.EnterText(driver, ContactUsLocators.subjectInputBy, subject);
        }
        public void EnterEmail(String email)
        {
            base.ScrollToElement(driver, ContactUsLocators.emailInputBy);
            base.EnterText(driver, ContactUsLocators.emailInputBy, email);
        }
        public void SelectCustomerServicesOption(string option)
        {
            base.ScrollToElement(driver, ContactUsLocators.customerServiceDropDownBy);
            base.SelectFromDropDown(driver, ContactUsLocators.customerServiceDropDownBy, option);
        }
        public void SelectCategory(string category)
        {
            base.ScrollToElement(driver, ContactUsLocators.categoryDropDownBy);
            base.SelectFromDropDown(driver, ContactUsLocators.categoryDropDownBy, category);
        }
        public void SelectType(string type)
        {
            base.ScrollToElement(driver, ContactUsLocators.typeDropDownBy);
            base.SelectFromDropDown(driver, ContactUsLocators.typeDropDownBy, type);
        }
        public void EnterMessage(String message)
        {
            base.ScrollToElement(driver, ContactUsLocators.messageInputBy);
            base.EnterText(driver, ContactUsLocators.messageInputBy, message);
        }
        public void ClickSubmitButton()
        {
            base.ScrollToElementAction(driver, ContactUsLocators.submitButtonBy);
            base.ClickElementByJs(driver, ContactUsLocators.submitButtonBy);
        }
        public void VerifySecCodeMsgDisplayedCorrectly()
        {
            string securityCodeTxt = base.GetText(driver, ContactUsLocators.secCodeErrMsgBy);
            Assert.True(base.ElementDisplayed(driver, ContactUsLocators.secCodeErrMsgBy), "Security Code Is Required Error Message Not Displayed");
            Assert.IsTrue(securityCodeTxt.Contains(expectedSecurityErrTxt), $"Required Security Message Is Incorrect: Expected {0} but fount {1}", expectedSecurityErrTxt, securityCodeTxt);
        }
    }
}
