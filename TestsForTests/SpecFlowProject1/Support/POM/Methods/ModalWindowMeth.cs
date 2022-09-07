using SpecFlowProject1.Support.POM.Locators;
using SpecFlowProject1.Support.DataForTests;
using SpecFlowProject1.Drivers;
using SpecFlowProject1.Support.DataForTests.Models;

namespace SpecFlowProject1.Support.POM.Methods
{
    internal class ModalWindowMeth
    {
        internal static string TakeActualText()
        {
            var actualText = BaseData.RemoveRedundantChars(DriverForBrowser.GetDriver().FindElement(ModalWindowLoc.successfullAddingText)
                .GetAttribute("textContent"));
            return actualText;
        }
        internal static void ClickOnMoveToCartButton() => DriverForBrowser.GetDriver()
            .FindElement(ModalWindowLoc.moveToCart).Click();
        internal static void CLickCloseModalWindow() => DriverForBrowser.GetDriver()
            .FindElement(ModalWindowLoc.closeModalWindow).Click();
    }
}
