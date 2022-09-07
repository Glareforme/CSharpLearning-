using SpecFlowProject1.Support.POM.Methods;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using SpecFlowProject1.Support.DataForTests.Models;
using SpecFlowProject1.Drivers;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class StepDefinitions
    {
        [Given(@"A search has been made for '([^']*)' with search field")]
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

        [Then(@"The following items are saved in the basket")]
        public void ThenTheFollowingItemsAreSavedInTheBasket(Table table)
        {
            var expectedData = table.CreateInstance<Parameters>();
            expectedData.Name = MainPageMeth.SavedNameOfProduct();
            expectedData.Price = MainPageMeth.SevedPriceOfProduct();
            ModalWindowMeth.ClickOnMoveToCartButton();
            var actualName = CartPageMeth.AddedToCartProductName(1);
            var actualPrice = CartPageMeth.AddedToCartProductPrice(1);
            Assert.IsTrue(actualName.Contains(expectedData.Name));
            Assert.IsTrue(expectedData.Price.Contains(actualPrice));
        }

        [When(@"User select in details for '([^']*)' and add  to cart")]
        public void WhenUserSelectInDetailsForAndAddToCart(string p0, Table table)
        {
            MainPageMeth.CLickOnMoreButton();
            var list = table.CreateInstance<Parameters>();
            ProductDetailsMeth.InputDetailsForProduct(list.Quantity, list.Size, list.Color);
            ProductDetailsMeth.AddToCart();
        }

        [Then(@"Message '([^']*)' displayed in modal window")]
        public void ThenMessageDisplayedInModalWindow(string expectedRes)
        {
            var actualMess = ModalWindowMeth.TakeActualText();

            Assert.IsTrue(expectedRes.Contains(actualMess));
        }

        [Given(@"A search has been made for '([^']*)' and add to cart first founded product with details")]
        [When(@"User search for '([^']*)' and add to cart '([^']*)' with details")]
        [When(@"User search for '([^']*)' and add to cart first found product with details")]
        public void WhenUserSearchForAndAddToCartWithDetails(string searchWord, Table table)
        {
            var list = table.CreateInstance<Parameters>();
            MainPageMeth.InputInSearchField(searchWord);
            MainPageMeth.ConfirmSearch();
            MainPageMeth.CLickOnMoreButton();
            ProductDetailsMeth.InputDetailsForProduct(list.Quantity, list.Size, list.Color);
            ProductDetailsMeth.AddToCart();
            ModalWindowMeth.CLickCloseModalWindow();
        }

        [When(@"User search for '([^']*)', add to cart first found product with details and open basket")]
        public void WhenUserSearchForAddToCartFirstFoundProductWithDetailsAndOpenBasket(string searchWord, Table table)
        {
            var list = table.CreateInstance<Parameters>();
            MainPageMeth.InputInSearchField(searchWord);
            MainPageMeth.ConfirmSearch();
            MainPageMeth.CLickOnMoreButton();
            ProductDetailsMeth.InputDetailsForProduct(list.Quantity, list.Size, list.Color);
            ProductDetailsMeth.AddToCart();
            ModalWindowMeth.ClickOnMoveToCartButton();
        }

        [Then(@"Correct information about added products")]
        public void ThenCorrectInformationAboutAddedProducts(Table table)
        {
            var expectedData = table.CreateInstance<ProductParamInCart>();
            var actualData = CartPageMeth.GetActualParameters();
            Assert.IsTrue(expectedData.Names.Equals(actualData.Names));
            Assert.IsTrue(expectedData.Pricies.Equals(actualData.Pricies));
            Assert.IsTrue(expectedData.Colors.Equals(actualData.Colors));
            Assert.IsTrue(expectedData.Quantities.Equals(actualData.Quantities));
            Assert.IsTrue(expectedData.Size.Equals(actualData.Size));
            Assert.IsTrue(expectedData.TotalPrice.Equals(actualData.TotalPrice));
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
            DriverForBrowser.RefreshPage();
            var actual = CartPageMeth.AddedToCartProductName(1);
            Assert.IsTrue(expected.Contains(actual));
        }
    }
}
