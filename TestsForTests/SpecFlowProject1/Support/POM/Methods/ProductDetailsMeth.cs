using SpecFlowProject1.Support.POM.Locators;
using SpecFlowProject1.Support.DataForTests;
using SpecFlowProject1.Drivers;
using OpenQA.Selenium;
using SpecFlowProject1.Support.DataForTests.Models;

namespace SpecFlowProject1.Support.POM.Methods
{
    internal class ProductDetailsMeth
    {
        internal static void InputDetailsForProduct(string quantry, string size, string color)
        {
            EnterQuantityWithKeyboard(quantry);
            SelectSize(size);
            SelectColor(color);
        }
        private static void EnterQuantityWithKeyboard(string quantry)
        {
            DriverForBrowser.GetDriver().FindElement(ProductDetailsLoc.quantryField).Clear();
            DriverForBrowser.GetDriver().FindElement(ProductDetailsLoc.quantryField).SendKeys(quantry);
        }
        private static void SelectSize(string selectedSize) => DriverForBrowser.SelectElementInDropDown(ProductDetailsLoc.selectSizeDropDown, selectedSize);
        private static void SelectColor(string color)
        {
            switch (color)
            {
                case ("Orange"):
                    {
                        DriverForBrowser.GetDriver().FindElement(ProductDetailsLoc.oragneSelectedColor).Click();
                        break;
                    }
                case ("Write"):
                    {
                        DriverForBrowser.GetDriver().FindElement(ProductDetailsLoc.whiteSelectedColor).Click();
                        break;
                    }
            }
        }
        internal static void AddToCart() => DriverForBrowser.GetDriver()
            .FindElement(ProductDetailsLoc.addToCartButton).Click();
    }
}
