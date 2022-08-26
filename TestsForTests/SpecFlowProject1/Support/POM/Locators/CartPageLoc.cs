using OpenQA.Selenium;

namespace SpecFlowProject1.Support.POM.Locators
{
    internal class CartPageLoc
    {
        internal static By nameOfFirstProduct = By.XPath("(//p[@class='product-name']/a)[1]");
        internal static By priceOfFirstProduct = By.XPath("//span[@class='price special-price']");
        internal static By deleteProductButton = By.XPath("(//a[@title='Delete'])[2]");

    }
}
