using SpecFlowProject1.Support.POM.Locators;
using SpecFlowProject1.Support.DataForTests;
using SpecFlowProject1.Drivers;
using SpecFlowProject1.Support.DataForTests.Models;

namespace SpecFlowProject1.Support.POM.Methods
{
    internal class CartPageMeth
    {
        internal static ProductParamInCart GetActualParameters()
        {
            var param = new ProductParamInCart();
            param.Names = AddedToCartProductName();
            param.Pricies = AddedToCartProductPrice();
            param.Quantities = AddedToCartProductsQuantities();
            param.Size = AddedToCartProductSize();
            param.Colors = AddedToCartProductsColor();
            param.TotalPrice = AddedToCartProductsTotalPrice();
            return param;
        }

        private static List<string> AddedToCartProductName()
        {
            var parameter = new ProductParamInCart();
            var temp = DriverForBrowser.GetDriver().FindElements(CartPageLoc.namesOfProducts);
            foreach (var item in temp)
            {
                parameter.Names.Add(BaseData.RemoveRedundantChars(item.GetAttribute("textContent")));
            }
            return parameter.Names;
        }

        private static List<string> AddedToCartProductPrice()
        {
            var parameter = new ProductParamInCart();
            var temp1 = DriverForBrowser.GetDriver().FindElement(CartPageLoc.priceofFirstProduct);
            var temp2 = DriverForBrowser.GetDriver().FindElement(CartPageLoc.priceOfSecondProduct);
            parameter.Pricies.Add(temp1.Text);
            parameter.Pricies.Add(temp2.Text);
            return parameter.Pricies;
        }

        private static List<string> AddedToCartProductSize()
        {
            var parameter = new ProductParamInCart();
            var temp = DriverForBrowser.GetDriver().FindElements(CartPageLoc.colorsAndDimensionsOfProducts);
            foreach (var item in temp)
            {
                parameter.Size.Add(BaseData.ExtractSizeOnCartPage(item.Text));
            }
            return parameter.Size;
        }

        private static List<string> AddedToCartProductsColor()
        {
            var par = new ProductParamInCart();
            var temp = DriverForBrowser.GetDriver().FindElements(CartPageLoc.colorsAndDimensionsOfProducts);
            foreach (var item in temp)
            {
                par.Colors.Add(BaseData.ExtractColorOnCartPage(item.Text));
            }
            return par.Colors;
        }

        private static List<string> AddedToCartProductsQuantities()
        {
            var par = new ProductParamInCart();
            var temp = DriverForBrowser.GetDriver().FindElements(CartPageLoc.quantitiesOfProducts);
            foreach (var item in temp)
            {
                par.Quantities.Add(BaseData.RemoveNonNumbers(item.GetAttribute("value")));
            }
            return par.Quantities;
        }

        private static List<string> AddedToCartProductsTotalPrice()
        {
            var par = new ProductParamInCart();
            var temp = DriverForBrowser.GetDriver().FindElements(CartPageLoc.totalPriciesOfProducts);
            foreach (var item in temp)
            {
                par.TotalPrice.Add(BaseData.RemoveNonNumbers(item.Text));
            }
            return par.TotalPrice;
        }

        internal static string AddedToCartProductName(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        ProductsParameters.Name = BaseData.RemoveRedundantChars(DriverForBrowser.GetDriver().FindElement(CartPageLoc.nameOfLastProduct)
                   .GetAttribute("textContent"));
                        return ProductsParameters.Name;
                        break;
                    }
                case 2:
                    {
                        ProductsParameters.Name = BaseData.RemoveRedundantChars(DriverForBrowser.GetDriver().FindElement(CartPageLoc.nameOfFirstProduct)
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
                    {
                        ProductsParameters.Price = BaseData.RemoveNonNumbers(DriverForBrowser.GetDriver().FindElement(CartPageLoc.priceOfSecondProduct).Text);
                        return (string)ProductsParameters.Price;
                        break;
                    }
                case 2:
                    {
                        ProductsParameters.Price = BaseData.RemoveNonNumbers(DriverForBrowser.GetDriver().FindElement(CartPageLoc.priceofFirstProduct).Text);
                        return (string)ProductsParameters.Price;
                        break;
                    }
            }
            return null;
        }

        internal static string AddedToCartProductSize(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        ProductsParameters.Size = BaseData.ExtractSizeOnCartPage(DriverForBrowser.GetDriver().FindElement(CartPageLoc.colorAndSizeOfSecondProduct).Text);
                        return ProductsParameters.Size;
                        break;
                    }
                case 2:
                    {
                        ProductsParameters.Size = BaseData.ExtractSizeOnCartPage(DriverForBrowser.GetDriver().FindElement(CartPageLoc.colorAndSizeOfFirstProduct).Text);
                        return ProductsParameters.Size;
                        break;
                    }
            }
            return null;
        }

        internal static string AddedToCartProductColor(int select)
        {
            switch (select)
            {
                case 1:
                    {
                        ProductsParameters.Color = BaseData.ExtractColorOnCartPage(DriverForBrowser.GetDriver().FindElement(CartPageLoc.colorAndSizeOfSecondProduct).Text);
                        return ProductsParameters.Color;
                        break;
                    }
                case 2:
                    {
                        ProductsParameters.Color = BaseData.ExtractColorOnCartPage(DriverForBrowser.GetDriver().FindElement(CartPageLoc.colorAndSizeOfFirstProduct).Text);
                        return ProductsParameters.Color;
                        break;
                    }
            }
            return null;
        }

        internal static void DeleteProductFromCart()
        {
            DriverForBrowser.MoveToElement(CartPageLoc.deleteProductButton);
            DriverForBrowser.GetDriver().FindElement(CartPageLoc.deleteProductButton).Click();
        }
    }
}
