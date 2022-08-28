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
            DriverForChrome.GetDriver().FindElement(MainPageLoc.searchInputField).Clear();
            DriverForChrome.GetDriver().FindElement(MainPageLoc.searchInputField).SendKeys(searchWord);

        }
        internal static void ConfirmSearch() => DriverForChrome.GetDriver()
            .FindElement(MainPageLoc.searchSubmitButton)
            .Click();
        internal static string GetTextFromSearchResult()
        {
            var actualResult = DriverForChrome.GetDriver()
                .FindElement(MainPageLoc.searchResultKeyWord)
                .Text;
            return BaseData.RemoveNonWords(actualResult);
        }
        internal static void ClickOnSortBy() => DriverForChrome.GetDriver().FindElement(MainPageLoc.productSortByForClick).Click();

        internal static void SelectOptionInDropDownList(string selectedOption)
        {
            DriverForChrome.SelectElementInDropDown(MainPageLoc.optionsForSelectInDropDown, selectedOption);
        }
        internal static bool CorrectSortByPrice()
        {
            var prisesForElements = new List<int>();
            var elementsAfterDiscont = DriverForChrome.GetDriver().FindElements(MainPageLoc.oldPricesForProducts);
            var originPrices = DriverForChrome.GetDriver().FindElements(MainPageLoc.currentPrices);
            for (int i = 0; i < 2; i++)
            {
                if (elementsAfterDiscont[i].Text != null)
                    prisesForElements.Add(Int32.Parse(BaseData.RemoveNonNumbers(elementsAfterDiscont[i].Text)));
                else
                    prisesForElements.Add(Int32.Parse(BaseData.RemoveNonNumbers(originPrices[i].Text)));
                prisesForElements.Add(1);
            }
            return OrderOfPrices.IsCorrectSort(prisesForElements);
        }
        internal static string SavedNameOfProduct()
        {
            ProductsParameters.Name = DriverForChrome.GetDriver().FindElement(MainPageLoc.nameOfSelectedProduct).GetAttribute("title");
            return ProductsParameters.Name;
        }
        internal static int SevedPriceOfProduct()
        {
            ProductsParameters.Price = Int32.Parse(BaseData.RemoveNonNumbers(DriverForChrome.GetDriver().FindElement(MainPageLoc.priceForSelectedProduct).Text));
            return (int)ProductsParameters.Price;
        }
        internal static void ClickAddToCart()
        {
            DriverForChrome.MoveToElement(MainPageLoc.productImage);
            DriverForChrome.GetDriver().FindElement(MainPageLoc.addToCartButton).Click();
        }
        internal static void OpenCart()
        {
            DriverForChrome.MoveToElement(MainPageLoc.openCartButton);
            DriverForChrome.GetDriver().FindElement(MainPageLoc.openCartButton).Click(); 
        }
        internal static void CLickOnMoreButton()
        {
            DriverForChrome.MoveToElement(MainPageLoc.productImage);
            DriverForChrome.GetDriver().FindElement(MainPageLoc.OpenMoreButton).Click();
        }
    }
}

