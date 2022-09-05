using SpecFlowProject1.Support.POM.Locators;
using SpecFlowProject1.Drivers;
using OpenQA.Selenium;
using SpecFlowProject1.Support.DataForTests;
using SpecFlowProject1.Support.DataForTests.Models;

namespace SpecFlowProject1.Support.POM.Methods
{
    internal static class MainPageMeth
    {
        internal static void InputInSearchField(string searchWord)
        {
            DriverForBrowser.GetDriver().FindElement(MainPageLoc.searchInputField).Clear();
            DriverForBrowser.GetDriver().FindElement(MainPageLoc.searchInputField).SendKeys(searchWord);

        }
        internal static void ConfirmSearch() => DriverForBrowser.GetDriver()
            .FindElement(MainPageLoc.searchSubmitButton)
            .Click();
        internal static string GetTextFromSearchResult()
        {
            var actualResult = DriverForBrowser.GetDriver()
                .FindElement(MainPageLoc.searchResultKeyWord)
                .Text;
            return BaseData.RemoveNonWords(actualResult);
        }
        internal static void ClickOnSortBy() => DriverForBrowser.GetDriver().FindElement(MainPageLoc.productSortByForClick).Click();

        internal static void SelectOptionInDropDownList(string selectedOption) => 
            DriverForBrowser.SelectElementInDropDown(MainPageLoc.optionsForSelectInDropDown, selectedOption);
        internal static bool CorrectSortByPrice()
        {
            var prisesForElements = new List<int>();
            var elementsAfterDiscont = DriverForBrowser.GetDriver().FindElements(MainPageLoc.oldPricesForProducts);
            var originPrices = DriverForBrowser.GetDriver().FindElements(MainPageLoc.currentPrices);
            for (int i = 0; i < 2; i++)
            {
                if (elementsAfterDiscont[i].Text != null)
                {
                    prisesForElements.Add(Int32.Parse(BaseData.RemoveNonNumbers(elementsAfterDiscont[i].Text)));
                }
                else
                {
                    prisesForElements.Add(Int32.Parse(BaseData.RemoveNonNumbers(originPrices[i].Text)));
                }
            }
            return OrderOfPrices.IsCorrectSort(prisesForElements);
        }
        internal static string SavedNameOfProduct()
        {
            ProductsParameters.Name = DriverForBrowser.GetDriver().FindElement(MainPageLoc.nameOfSelectedProduct).GetAttribute("title");
            return ProductsParameters.Name;
        }
        internal static string SevedPriceOfProduct()
        {
            ProductsParameters.Price = BaseData.RemoveNonNumbers(DriverForBrowser.GetDriver().FindElement(MainPageLoc.priceForSelectedProduct).Text);
            return (string)ProductsParameters.Price;
        }
        internal static void ClickAddToCart()
        {
            DriverForBrowser.MoveToElement(MainPageLoc.productImage);
            DriverForBrowser.GetDriver().FindElement(MainPageLoc.addToCartButton).Click();
        }
        internal static void OpenCart()
        {
            DriverForBrowser.MoveToElement(MainPageLoc.openCartButton);
            DriverForBrowser.GetDriver().FindElement(MainPageLoc.openCartButton).Click(); 
        }
        internal static void CLickOnMoreButton()
        {
            DriverForBrowser.MoveToElement(MainPageLoc.productImage);
            DriverForBrowser.GetDriver().FindElement(MainPageLoc.OpenMoreButton).Click();
        }
    }
}

