using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace PageObjectModel.POM.SetUp
{
    public static class SetUpTests
    {
        private static WebDriver _driver;
        private static Actions action;
        public static WebDriver CreateBrowser()
        {
            var options = new ChromeOptions();
            options.AddArguments("--start-maximized");
            _driver = new ChromeDriver(options);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return _driver;
        }
        public static WebDriver GetBrowser()
        {
            return _driver;
        }
        public static void ReturnText(By element)
        {
            string text = _driver.FindElement(element).Text;
            Console.WriteLine(text);
        }
        public static void QuitBrowser()
        {
            _driver.Quit();
        }
        internal static void MoveToElement(By selector)
        {
            action = new Actions(_driver);
            var element = _driver.FindElement(selector);
            action.MoveToElement(element);
            action.Perform();
        }
    }
}
