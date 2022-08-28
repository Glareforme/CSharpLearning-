using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowProject1.Drivers
{
    internal static class DriverForBrowser
    {   
        private static Actions action;
        private static IWebDriver _driver;
        private static SelectElement dropDown;
        private static void CreateDriver()
        {
            var option = new ChromeOptions();
            option.AddArguments("--start-maximized");
            _driver = new ChromeDriver(option);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        internal static IWebDriver GetDriver()
        {
            if (_driver == null)
                CreateDriver();

            return _driver;
        }
        internal static void CleanDriver()
        {
            // Open new empty tab.
            _driver.ExecuteJavaScript("window.open('');");

            // Close all tabs but one tab and delete all cookies.
            for (var tabs = _driver.WindowHandles; tabs.Count > 1; tabs = _driver.WindowHandles)
            {
                _driver.SwitchTo().Window(tabs[0]);
                _driver.Manage().Cookies.DeleteAllCookies();
                _driver.Close();
            }

            // Switch to empty tab.
            _driver.SwitchTo().Window(_driver.WindowHandles[0]);
        }
        internal static void CloseDriver() => _driver.Quit();
        internal static void MoveToElement(By selector)
        {
            action = new Actions(_driver);
            var element = _driver.FindElement(selector);
            action.MoveToElement(element);
            action.Perform();
        }
        internal static void SelectElementInDropDown(By element, string selector)
        {
            dropDown = new SelectElement(_driver.FindElement(element));
            dropDown.SelectByText(selector);
        }
        internal static void RefreshPage() => _driver.Navigate().Refresh();
        internal static void WaitForElement(By element)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            wait.Until(el => el.FindElement(element).Displayed);
        }
    }
}
