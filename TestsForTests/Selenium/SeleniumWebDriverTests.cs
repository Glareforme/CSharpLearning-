using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.locators;
using System.Collections;

namespace Selenium

{
    public class Tests
    {
        WebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            //task1
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(" http://automationpractice.com/");
        }

        [Test]
        public void Task1()
        {

            //task 2
            var output =  driver.FindElements(MainPageLocators.TabsNames);
            int i = 1;
            foreach (var item in output)
            {
                Console.WriteLine($"Title {i}:" + item.Text);
                i++;
            }
            //task 3
            var outpup = driver.FindElement(MainPageLocators.SearchSubmitButton).GetAttribute("name");
            Console.WriteLine("Attribute name - " + outpup);
            //task 4
            driver.FindElement(MainPageLocators.BestSellersButton);
            //task 5
            driver.FindElement(MainPageLocators.SearchInputField).SendKeys("dsadaxzc");
            driver.FindElement(MainPageLocators.SearchSubmitButton).Click();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}