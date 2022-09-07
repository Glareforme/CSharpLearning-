using OpenQA.Selenium;

namespace SpecFlowProject1.Support.POM.Locators
{
    internal class CartPageLoc
    {
        internal static By namesOfProducts = By.XPath("//td[@class='cart_description']//p[@class='product-name']/a");
        internal static By colorsAndDimensionsOfProducts = By.XPath("//td[@class='cart_description']/small/a");
        internal static By quantitiesOfProducts = By.XPath("//td[@class='cart_quantity text-center']/input[@class='cart_quantity_input form-control grey']");
        internal static By totalPriciesOfProducts = By.XPath("//td[@class='cart_total']/span[@class='price']"); 

        internal static By nameOfLastProduct = By.XPath("(//p[@class='product-name']/a)[1]");
        internal static By nameOfFirstProduct = By.XPath("(//p[@class='product-name']/a)[2]");
        internal static By priceOfSecondProduct = By.XPath("//span[@class='price special-price']");
        internal static By priceofFirstProduct = By.XPath("//td[@data-title='Unit price']/span//span[@class='price']");
        internal static By deleteProductButton = By.XPath("(//a[@title='Delete'])[2]");
        internal static By colorAndSizeOfSecondProduct = By.XPath("(//td[@class='cart_description']/small/a)[2]");
        internal static By colorAndSizeOfFirstProduct = By.XPath("(//td[@class='cart_description']/small/a)[1]");
        internal static By quantityOfFirstProduct = By.XPath("(//td[@class='cart_quantity text-center']/input[@class='cart_quantity_input form-control grey'])[1]");
        internal static By quantityOfSecondProduct = By.XPath("(//td[@class='cart_quantity text-center']/input[@class='cart_quantity_input form-control grey'])[2]");
        internal static By totalPriceOfFirstProduct = By.XPath("(//td[@class='cart_total']/span[@class='price'])[1]");
        internal static By totalPriceOfSecondProduct = By.XPath("(//td[@class='cart_total']/span[@class='price'])[2]");
    }
    //td[@class='cart_unit']//span[@class='price special-price']
}