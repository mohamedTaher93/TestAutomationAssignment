using OpenQA.Selenium;

namespace TestAutomationAssignment.ObjRepo
{
    public class HomeLocators
    {
        public static readonly By homePopUpBy = By.Id("HomePopup");
        public static readonly By closePopUpBy = By.XPath("//div[@id= 'HomePopup' and contains(@style,'display: block')]//button[@class='btn-close']");
        public static readonly By switchToEnglishBtnBy = By.XPath("//div[@class = 'dda-sub-header__actions']//a[@title= 'Switch to English']");
        public static readonly By contactUsBtnBy = By.XPath("//footer//a[@href= '/AboutUs/Contact-Us']");
    }
}
