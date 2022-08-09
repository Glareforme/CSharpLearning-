namespace Selenium.locators
{
    internal class XpathAndCSS
    {
        /// <summary>
        /// Локаторы для задания 
        /// </summary>
        //xpash
        const string ChangeToListButton = "//li[@id='list']"; 
        const string DressesButton = "(//a[@title='Dresses'])[2]";
        const string SearchTitle = "//span[@class='lighter']";
        const string SearchByDropDown = "//div[@id='uniform-selectProductSort']";
        const string SelectInDropDownZ_A = "//option[text()='Product Name: Z to A']";
        const string AddToCartButton = "(//a[@title='Add to cart'])[2]";
        //css
        const string a = "li#list";
        const string b = "a[title=Dresses]";
        const string c = "span.lighter";
        const string d = "div#uniform-selectProductSort";
        const string e = "a[title='Add to cart']";

    }
}
