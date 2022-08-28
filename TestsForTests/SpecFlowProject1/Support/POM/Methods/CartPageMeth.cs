using SpecFlowProject1.Support.POM.Locators;
using SpecFlowProject1.Support.DataForTests;
using SpecFlowProject1.Drivers;
using SpecFlowProject1.Support.DataForTests.Models;

namespace SpecFlowProject1.Support.POM.Methods
{
    internal class CartPageMeth
    {
        internal static string AddedToCartProductName(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        ProductsParameters.Name = BaseData.RemoveRedundantChars(DriverForChrome.GetDriver().FindElement(CartPageLoc.nameOfLastProduct)
                   .GetAttribute("textContent"));
                        return ProductsParameters.Name;
                        break;
                    }
                case 2:
                    {
                        ProductsParameters.Name = BaseData.RemoveRedundantChars(DriverForChrome.GetDriver().FindElement(CartPageLoc.nameOfFirstProduct)
                  .GetAttribute("textContent"));
                        return ProductsParameters.Name;
                        break;
                    }
            }
            return null;
        }
        internal static int AddedToCartProductPrice()
        {
            ProductsParameters.Price = Int32.Parse(BaseData.RemoveNonNumbers(DriverForChrome.GetDriver().FindElement(CartPageLoc.priceOfFirstProduct).Text));
            return (int)ProductsParameters.Price;
        }
        internal static void DeleteProductFromCart()
        {
            DriverForChrome.MoveToElement(CartPageLoc.deleteProductButton);
            DriverForChrome.GetDriver().FindElement(CartPageLoc.deleteProductButton).Click();
        }
    }
}
