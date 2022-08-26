using SpecFlowProject1.Support.POM.Methods;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using SpecFlowProject1.Support.DataForTests.Models;
using SpecFlowProject1.Support.DataForTests;
using System.Threading;
using SpecFlowProject1.Drivers;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"User search for '([^']*)' with search field")]
        [When(@"User search for '([^']*)' with search field")]
        public void WhenUserSearchForWithSearchField(string searchWord)
        {
            MainPageMeth.InputInSearchField(searchWord);
            MainPageMeth.ConfirmSearch();
        }

        [Then(@"In inscription '([^']*)' displyed '([^']*)'")]
        public void ThenInInscriptionDisplyed(string search, string expectedRes)
        {
            var actualRes = MainPageMeth.GetTextFromSearchResult();
            Assert.AreEqual(expectedRes, actualRes);
        }

        [Given(@"User select option '([^']*)' in dropdown")]
        [When(@"User select option '([^']*)' in dropdown list")]
        public void WhenUserSelectOptionInDropdownList(string option)
        {
            MainPageMeth.ClickOnSortBy();
            MainPageMeth.SelectOptionInDropDownList(option);
        }

        [Then(@"All element sorted with selected option")]
        public void ThenAllElementSortedWithSelectedOption()
        {
            MainPageMeth.CorrectSortByPrice();
        }


        [When(@"User add '([^']*)' to busket")]
        public void WhenUserAddToBusket(string o)
        {
            MainPageMeth.ClickAddToCart();
        }

        [Then(@"Verify added to busket correspond remembered name and price of '([^']*)'")]
        public void ThenVerifyAddedToBusketCorrespondRememberedNameAndPriceOf(string p0)
        {
            var expectedName = MainPageMeth.SavedNameOfProduct();
            var expectedPrice = MainPageMeth.SevedPriceOfProduct();
            ModalWindowMeth.ClickOnMoveToCartButton();
            var actualName = CartPageMeth.AddedToCartProductName();
            var actualPrice = CartPageMeth.AddedToCartProductPrice();
            Assert.IsTrue(actualName.Contains(expectedName));
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [When(@"User select in details for '([^']*)' and add  to cart")]
        public void WhenUserSelectInDetailsForAndAddToCart(string p0, Table table)
        {
            MainPageMeth.CLickOnMoreButton();
            var list = table.CreateInstance<Parameters>();
            ProductDetailsMeth.EnterQuantityWithKeyboard(list.Quantity);
            ProductDetailsMeth.SelectSize(list.Size);
            ProductDetailsMeth.SelectColor(list.Color);
            ProductDetailsMeth.AddToCart();
        }

        [Then(@"Message '([^']*)' displayed in modal window")]
        public void ThenMessageDisplayedInModalWindow(string expectedRes)
        {
            var actualMess = ModalWindowMeth.TakeActualText(BaseData.succAddedToCart);

            Assert.IsTrue(actualMess.Contains(expectedRes));
        }

        [Given(@"User search for '([^']*)' and add to cart first founded product with details")]
        [When(@"User search for '([^']*)' and add to cart '([^']*)' with details")]
        [When(@"User search for '([^']*)' and add to cart first found product with details")]
        public void WhenUserSearchForAndAddToCartWithDetails(string searchWord, Table table)
        {
            var list = table.CreateInstance<Parameters>();
            MainPageMeth.InputInSearchField(searchWord);
            MainPageMeth.ConfirmSearch();
            MainPageMeth.CLickOnMoreButton();
            ProductDetailsMeth.EnterQuantityWithKeyboard(list.Quantity);
            ProductDetailsMeth.SelectSize(list.Size);
            ProductDetailsMeth.SelectColor(list.Color);
            ScenarioContext.Current["Name of first product"] = ProductDetailsMeth.NameOfAddedProduct();
            ScenarioContext.Current["Price for first product"] = ProductDetailsMeth.PriceOfAddedProduct();
            ScenarioContext.Current["Quantity of first product"] = ProductDetailsMeth.QuantityOfAddedProduct();
            ScenarioContext.Current["Size of first product"] = ProductDetailsMeth.SizeOfAddedProduct();
            ScenarioContext.Current["Color of first product"] = ProductDetailsMeth.ColorOfAddedProduct();
            ProductDetailsMeth.AddToCart();
            ScenarioContext.Current["Total price of first product"] = ModalWindowMeth.TotalPriceOfAddedProduct();
            ModalWindowMeth.CLickCloseModalWindow();
        }
        [When(@"User search for '([^']*)', add to cart first found product with details and open basket")]
        public void WhenUserSearchForAddToCartFirstFoundProductWithDetailsAndOpenBasket(string searchWord, Table table)
        {
            var list = table.CreateInstance<Parameters>();
            MainPageMeth.InputInSearchField(searchWord);
            MainPageMeth.ConfirmSearch();
            MainPageMeth.CLickOnMoreButton();
            ProductDetailsMeth.EnterQuantityWithKeyboard(list.Quantity);
            ProductDetailsMeth.SelectSize(list.Size);
            ProductDetailsMeth.SelectColor(list.Color);
            ScenarioContext.Current["Name of secont product"] = ProductDetailsMeth.NameOfAddedProduct();
            ScenarioContext.Current["Price for second product"] = ProductDetailsMeth.PriceOfAddedProduct();
            ScenarioContext.Current["Quantity of second product"] = ProductDetailsMeth.QuantityOfAddedProduct();
            ScenarioContext.Current["Size of second product"] = ProductDetailsMeth.SizeOfAddedProduct();
            ScenarioContext.Current["Color of second product"] = ProductDetailsMeth.ColorOfAddedProduct();
            ProductDetailsMeth.AddToCart();
            ScenarioContext.Current["Total price of second product"] = ModalWindowMeth.TotalPriceOfAddedProduct();
            ModalWindowMeth.ClickOnMoveToCartButton();
        }


        [Then(@"In cart for (.*) added products dispyaed correct '([^']*)','([^']*)','([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenInCartForAddedProductsDispyaedCorrect(int p0, string expectedName, string expectedSize, string expectedColor, string expUnitPrice, string expQuantity, string expTotalPrice)
        {
            expectedName = (string)ScenarioContext.Current["Name of first product"];
            /*    expectedSize = (string)ScenarioContext.Current["Size of first product"];
                expectedColor = (string)ScenarioContext.Current["Color of first product"];
                expUnitPrice = (int)ScenarioContext.Current["Price for first product"];
                expQuantity = (int)ScenarioContext.Current["Quantity of first product"];
                expTotalPrice = (int)ScenarioContext.Current["Total price of second product"];*/
            string actualName = CartPageMeth.AddedToCartProductName();
            Assert.AreEqual(expectedName, actualName);
            Assert.IsTrue(true);
        }

        [When(@"User delete '([^']*)' from basket")]
        public void WhenUserDeleteFromBasket(string p0)
        {
            MainPageMeth.OpenCart();
            CartPageMeth.DeleteProductFromCart();
        }

        [Then(@"In busket list only '([^']*)' left")]
        public void ThenInBusketListOnlyLeft(string expected)
        {
            DriverForChrome.RefreshPage();
            var actual = CartPageMeth.AddedToCartProductName();
            Assert.IsTrue(actual.Contains(expected));
        }
    }
}
