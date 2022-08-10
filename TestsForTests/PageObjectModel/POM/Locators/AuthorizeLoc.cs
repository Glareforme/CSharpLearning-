using OpenQA.Selenium;

namespace PageObjectModel.POM.Locators
{
    internal class AuthorizeLoc
    {
        internal static By AuthModuleTitle = By.XPath("//h3[text()='Already registered?']");
        internal static By EmailInputField = By.Id("email");
        internal static By PasswordInputField = By.Id("passwd");
        internal static By ConfirmSingInButton = By.Id("SubmitLogin");
    }
}
