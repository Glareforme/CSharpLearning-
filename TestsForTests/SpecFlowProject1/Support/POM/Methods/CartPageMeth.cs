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
        internal static string AddedToCartProductPrice(int select)
        {
            switch (select)
            {
                case 1:
                    ProductsParameters.Price = BaseData.RemoveNonNumbers(DriverForChrome.GetDriver().FindElement(CartPageLoc.priceOfSecondProduct).Text);
                    return (string)ProductsParameters.Price;
                    break;
                case 2:
                    ProductsParameters.Price = BaseData.RemoveNonNumbers(DriverForChrome.GetDriver().FindElement(CartPageLoc.priceofFirstProduct).Text);
                    return (string)ProductsParameters.Price;
                    break;
            }
            return null;
        }
        internal static string AddedToCartProductSize(int select)
        {
            switch (select)
            {
                case 1:
                    ProductsParameters.Size = BaseData.ExtractSizeOnCartPage(DriverForChrome.GetDriver().FindElement(CartPageLoc.colorAndSizeOfSecondProduct).Text);
                    return ProductsParameters.Size;
                    break;
                case 2:
                    ProductsParameters.Size = BaseData.ExtractSizeOnCartPage(DriverForChrome.GetDriver().FindElement(CartPageLoc.colorAndSizeOfFirstProduct).Text);
                    return ProductsParameters.Size;
                    break;
            }
            return null;
        }
        internal static string AddedToCartProductColor(int select)
        {
            switch (select)
            {
                case 1:
                    ProductsParameters.Color = BaseData.ExtractColorOnCartPage(DriverForChrome.GetDriver().FindElement(CartPageLoc.colorAndSizeOfSecondProduct).Text);
                    return ProductsParameters.Color;
                    break;
                case 2:
                    ProductsParameters.Color = BaseData.ExtractColorOnCartPage(DriverForChrome.GetDriver().FindElement(CartPageLoc.colorAndSizeOfFirstProduct).Text);
                    return ProductsParameters.Color;
                    break;
            }
            return null;
        }
        internal static string AddedToCartProductQuantity(int select)
        {
            switch (select)
            {
                case 2:
                    ProductsParameters.QuantityOfGoods = DriverForChrome.GetDriver().FindElement(CartPageLoc.quantityOfFirstProduct).GetAttribute("value");
                    return (string)ProductsParameters.QuantityOfGoods;
                    break;
                case 1:
                    ProductsParameters.QuantityOfGoods = DriverForChrome.GetDriver().FindElement(CartPageLoc.quantityOfSecondProduct).GetAttribute("value");
                    return (string)ProductsParameters.QuantityOfGoods;
                    break;
            }
            return null;
        }
        internal static string AddedToCartProductTotalPrice(int select)
        {
            switch (select)
            {
                case 2:
                    ProductsParameters.TotalPrice = BaseData.RemoveNonNumbers(DriverForChrome.GetDriver().FindElement(CartPageLoc.totalPriceOfFirstProduct).Text);
                    return (string)ProductsParameters.TotalPrice;
                    break;
                case 1:
                    ProductsParameters.TotalPrice = BaseData.RemoveNonNumbers(DriverForChrome.GetDriver().FindElement(CartPageLoc.totalPriceOfSecondProduct).Text);
                    return (string)ProductsParameters.TotalPrice;
                    break;
            }
            return null;
        }
        internal static void DeleteProductFromCart()
        {
            DriverForChrome.MoveToElement(CartPageLoc.deleteProductButton);
            DriverForChrome.GetDriver().FindElement(CartPageLoc.deleteProductButton).Click();
        }
    }
}
