using OpenQA.Selenium;
using PageObjectModel.POM.Locators;
using PageObjectModel.POM.SetUp;

namespace PageObjectModel.POM.Methods
{
    internal static class AuthorizeMeth
    {
        public static void OutputAuthorizeTitleText() => SetUpTests.ReturnText(AuthorizeLoc.AuthModuleTitle);
        public static void InputInEmailField()
        {
            try
            {
                SetUpTests.GetBrowser().FindElement(AuthorizeLoc.EmailInputField).SendKeys("hiofvnc");
            }
            catch (NoSuchElementException)
            {
                SetUpTests.MoveToElement(AuthorizeLoc.EmailInputField);
                SetUpTests.GetBrowser().FindElement(AuthorizeLoc.EmailInputField).SendKeys("hiofvnc");
            }

        }
        public static void InputInPasswordField()
        {
            try
            {
                SetUpTests.GetBrowser().FindElement(AuthorizeLoc.ConfirmSingInButton).Click();
            }
            catch (NoSuchElementException)
            {
                SetUpTests.MoveToElement(AuthorizeLoc.PasswordInputField);
                SetUpTests.GetBrowser().FindElement(AuthorizeLoc.PasswordInputField).SendKeys("dsacvxvx");
            }
        }
        public static void CorfirmInput()
        {
            try
            {
                SetUpTests.GetBrowser().FindElement(AuthorizeLoc.ConfirmSingInButton).Click();
            }
            catch (NoSuchElementException)
            {
                SetUpTests.MoveToElement(AuthorizeLoc.ConfirmSingInButton);
                SetUpTests.GetBrowser().FindElement(AuthorizeLoc.ConfirmSingInButton).Click();
            }
        }
    }
}
