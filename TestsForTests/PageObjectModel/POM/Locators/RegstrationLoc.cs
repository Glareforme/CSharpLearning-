using OpenQA.Selenium;

namespace PageObjectModel.POM.Locators
{
    internal class RegstrationLoc
    {
        internal static By ModuleTitle = By.XPath("//h3[text()='Create an account']");
        internal static By emailInputField = By.XPath("//input[@id='email_create']");
        internal static By confirmButton = By.XPath("");
        internal static By HintText = By.XPath("(//div[@class='form_content clearfix']/p)[1]");

    }
}
