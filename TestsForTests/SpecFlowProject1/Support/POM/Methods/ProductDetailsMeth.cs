using SpecFlowProject1.Support.POM.Locators;
using SpecFlowProject1.Support.DataForTests;
using SpecFlowProject1.Drivers;
using OpenQA.Selenium;
using SpecFlowProject1.Support.DataForTests.Models;

namespace SpecFlowProject1.Support.POM.Methods
{
    internal class ProductDetailsMeth
    {
        internal static void EnterQuantityWithKeyboard(string quantry)
        {
            DriverForChrome.GetDriver().FindElement(ProductDetailsLoc.quantryField).Clear();
            DriverForChrome.GetDriver().FindElement(ProductDetailsLoc.quantryField).SendKeys(quantry);
        }
        internal static void SelectSize(string selectedSize) => DriverForChrome.SelectElementInDropDown(ProductDetailsLoc.selectSizeDropDown, selectedSize);
        internal static void SelectColor(string color)
        {
            switch (color)
            {
                case ("Orange"):
                    DriverForChrome.GetDriver().FindElement(ProductDetailsLoc.oragneSelectedColor).Click();
                    break;
                case ("Write"):
                    DriverForChrome.GetDriver().FindElement(ProductDetailsLoc.whiteSelectedColor).Click();
                    break;
            }
        }
        internal static void AddToCart() => DriverForChrome.GetDriver()
            .FindElement(ProductDetailsLoc.addToCartButton).Click();
        internal static string NameOfAddedProduct()
        {
            ProductsParameters.Name = DriverForChrome.GetDriver().FindElement(ProductDetailsLoc.productName).Text;
            return ProductsParameters.Name;
        }
        internal static int PriceOfAddedProduct()
        {
            ProductsParameters.Price = Int32.Parse(BaseData.RemoveNonNumbers(DriverForChrome.GetDriver()
                .FindElement(ProductDetailsLoc.priceProduct).Text));
            return  ProductsParameters.Price;
        }
        internal static int QuantityOfAddedProduct()
        {
            ProductsParameters.QuantityOfGoods = Int32.Parse(BaseData.RemoveNonNumbers(DriverForChrome.GetDriver()
                .FindElement(ProductDetailsLoc.quantityOfProduct).GetAttribute("value")));
            return ProductsParameters.QuantityOfGoods;
        }
        internal static string ColorOfAddedProduct()
        {
            ProductsParameters.Color = DriverForChrome.GetDriver()
                .FindElement(ProductDetailsLoc.getSelectedColor).GetAttribute("title");
            return ProductsParameters.Color;
        }
        internal static string SizeOfAddedProduct()
        {
            ProductsParameters.Size = DriverForChrome.GetDriver()
                .FindElement(ProductDetailsLoc.getSelectedSize).Text;
            return ProductsParameters.Size;
        }
    }
}
