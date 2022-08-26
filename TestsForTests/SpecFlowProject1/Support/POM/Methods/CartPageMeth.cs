using SpecFlowProject1.Support.POM.Locators;
using SpecFlowProject1.Support.DataForTests;
using SpecFlowProject1.Drivers;
using SpecFlowProject1.Support.DataForTests.Models;

namespace SpecFlowProject1.Support.POM.Methods
{
    internal class CartPageMeth
    {
        internal static string AddedToCartProductName()
        {
            ProductsParameters.Name = DriverForChrome.GetDriver().FindElement(CartPageLoc.nameOfFirstProduct)
                .GetAttribute("textContent");
            return ProductsParameters.Name;
        }
        internal static int AddedToCartProductPrice() 
        {
            ProductsParameters.Price = Int32.Parse(BaseData.RemoveNonNumbers(DriverForChrome.GetDriver().FindElement(CartPageLoc.priceOfFirstProduct).Text));
            return ProductsParameters.Price;
        }
        internal static void DeleteProductFromCart()
        {
            DriverForChrome.MoveToElement(CartPageLoc.deleteProductButton);
            DriverForChrome.GetDriver().FindElement(CartPageLoc.deleteProductButton).Click();
        }
    }
}
