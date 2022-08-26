using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.Drivers
{
    internal static class DriverForChrome
    {   
        private static Actions action;
        private static IWebDriver _chromedriver;
        private static SelectElement dropDown;
        private static WebDriverWait wait;
        private static void CreateChromeDriver()
        {
            var option = new ChromeOptions();
            option.AddArguments("--start-maximized");
            _chromedriver = new ChromeDriver(option);
            _chromedriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        internal static IWebDriver GetDriver()
        {
            if (_chromedriver == null)
                CreateChromeDriver();

            return _chromedriver;
        }
        internal static void CleanDriver()
        {
            // Open new empty tab.
            _chromedriver.ExecuteJavaScript("window.open('');");

            // Close all tabs but one tab and delete all cookies.
            for (var tabs = _chromedriver.WindowHandles; tabs.Count > 1; tabs = _chromedriver.WindowHandles)
            {
                _chromedriver.SwitchTo().Window(tabs[0]);
                _chromedriver.Manage().Cookies.DeleteAllCookies();
                _chromedriver.Close();
            }

            // Switch to empty tab.
            _chromedriver.SwitchTo().Window(_chromedriver.WindowHandles[0]);
        }
        internal static void CloseDriver() => _chromedriver.Quit();
        internal static void MoveToElement(By selector)
        {
            action = new Actions(_chromedriver);
            var element = _chromedriver.FindElement(selector);
            action.MoveToElement(element);
            action.Perform();
        }
        internal static void SelectElementInDropDown(By element, string selector)
        {
            dropDown = new SelectElement(_chromedriver.FindElement(element));
            dropDown.SelectByText(selector);
        }
        internal static void RefreshPage() => _chromedriver.Navigate().Refresh();
        internal static void WaitForElement(By element)
        {
            var wait = new WebDriverWait(_chromedriver, TimeSpan.FromSeconds(20));
            wait.Until(el => el.FindElement(element).Displayed);
        }
    }
}
