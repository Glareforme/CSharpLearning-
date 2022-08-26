using SpecFlowProject1.Support.POM.Locators;
using SpecFlowProject1.Support.DataForTests;
using SpecFlowProject1.Drivers;
using SpecFlowProject1.Support.DataForTests.Models;

namespace SpecFlowProject1.Support.POM.Methods
{
    internal class ModalWindowMeth
    {
        internal static string TakeActualText(string text)
        {
            var actualText = DriverForChrome.GetDriver().FindElement(ModalWindowLoc.successfullAddingText)
                .GetAttribute("textContent");
            return actualText;
        }
        internal static void ClickOnMoveToCartButton() => DriverForChrome.GetDriver()
            .FindElement(ModalWindowLoc.moveToCart).Click();
        internal static void CLickCloseModalWindow() => DriverForChrome.GetDriver()
            .FindElement(ModalWindowLoc.closeModalWindow).Click();
        internal static int TotalPriceOfAddedProduct()
        {
            DriverForChrome.WaitForElement(ModalWindowLoc.totalPriceOfProduct);
            ProductsParameters.TotalPrice = Int32.Parse(BaseData.RemoveNonNumbers(DriverForChrome.GetDriver()
                .FindElement(ModalWindowLoc.totalPriceOfProduct).Text));
            return ProductsParameters.TotalPrice;
        }
    }
}
