using OpenQA.Selenium;

namespace TestAutomationAssignment.ObjRepo
{
    public class ContactUsLocators
    {
        public static readonly By contactUsHeader = By.XPath("//div[@id = 'main']//h2[text() = 'CONTACT US']");
        public static readonly By fullNameInputBy = By.XPath("//input[@placeholder='Full Name']");
        public static readonly By mobileNumberInputBy = By.XPath("//label[@for='feedMobile']/following-sibling::input[@type='number']");
        public static readonly By subjectInputBy = By.XPath("//div[@class='contact-details-tab']//input[@id='feedbackSubject']");
        public static readonly By emailInputBy = By.XPath("//div[@class='contact-details-tab']//input[@id='feedEmail']");
        public static readonly By customerServiceDropDownBy = By.XPath("//div[@class='contact-details-tab']//select[@id='feedCall']");
        public static readonly By categoryDropDownBy = By.XPath("//div[@class='contact-details-tab']//select[@id = 'feedReason']");
        public static readonly By typeDropDownBy = By.XPath("//div[@class='contact-details-tab']//select[@id = 'feedType']");
        public static readonly By messageInputBy = By.XPath("//textarea[@id='feedComment']");
        public static readonly By submitButtonBy = By.XPath("//div[@class = 'addressFormWrapper']//input[@value= 'Submit']");
        public static readonly By secCodeErrMsgBy = By.XPath("//span[@id = 'captchaerrorContact' and (contains(text(), 'Security Code is Required'))]");
        public static readonly By footer = By.XPath("//input[@type='submit']/ancestor::div[@class='row']");
    }
}
