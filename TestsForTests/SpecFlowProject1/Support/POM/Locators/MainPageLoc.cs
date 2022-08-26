using OpenQA.Selenium;

namespace SpecFlowProject1.Support.POM.Locators
{
    internal static class MainPageLoc
    {
        internal static By searchInputField = By.Id("search_query_top");
        internal static By searchSubmitButton = By.XPath("//button[@name='submit_search']");
        internal static By searchResultKeyWord = By.XPath("//span[@class='lighter']");
        internal static By productSortByForClick = By.Id("uniform-selectProductSort");
        internal static By optionsForSelectInDropDown = By.Id("selectProductSort");
        internal static By oldPricesForProducts = By.XPath("//div[@class='right-block']//span[@class='old-price product-price']");
        internal static By currentPrices = By.XPath("//div[@class='right-block']//span[@class='price product-price']");
        internal static By addToCartButton = By.XPath("(//a[@title='Add to cart'])[1]");
        internal static By nameOfSelectedProduct = By.XPath("(//ul[@class='product_list grid row']//a[@class='product-name'])[1]");
        internal static By priceForSelectedProduct = By.XPath("(//span[@itemprop='price'])[1]");
        internal static By openCartButton = By.XPath("//a[@title='View my shopping cart']");
        internal static By productImage = By.XPath("(//div[@class='product-image-container'])[1]");
        internal static By OpenMoreButton = By.XPath("(//span[text()='More'])[1]");
    }
}
