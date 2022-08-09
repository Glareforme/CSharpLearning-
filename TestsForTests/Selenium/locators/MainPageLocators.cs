using OpenQA.Selenium;

namespace Selenium.locators
{
    internal class MainPageLocators
    {
        internal static By BestSellersButton = By.XPath("//a[text()='Best Sellers']");
        internal static By TabsNames = By.XPath("//ul[@class='sf-menu clearfix menu-content sf-js-enabled sf-arrows']/li");
        internal static By SearchInputField = By.XPath("//input[@id='search_query_top']");
        internal static By SearchSubmitButton = By.XPath("//button[@name='submit_search']");
    }
}
