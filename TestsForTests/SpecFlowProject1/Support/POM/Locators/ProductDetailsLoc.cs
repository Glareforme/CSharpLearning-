using OpenQA.Selenium;

namespace SpecFlowProject1.Support.POM.Locators
{
    internal class ProductDetailsLoc
    {
        internal static By quantryField = By.Id("quantity_wanted");
        internal static By productName = By.XPath("//h1[@itemprop='name']");
        internal static By priceProduct = By.Id("our_price_display");
        internal static By quantityOfProduct = By.Id("quantity_wanted");
        internal static By selectSizeDropDown = By.Id("group_1");
        internal static By oragneSelectedColor = By.Id("color_13");
        internal static By whiteSelectedColor = By.XPath("//a[@name='White']");
        internal static By getSelectedColor = By.XPath("//li[@class='selected']/a");
        internal static By getSelectedSize = By.XPath("//div[@class='attribute_list']/div[@class]/span");
        internal static By addToCartButton = By.XPath("//button[@name='Submit']");
    }
}
