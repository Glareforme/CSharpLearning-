using SpecFlowProject1.Support.POM.Methods;
using NUnit.Framework;
using TechTalk.SpecFlow.Assist;
using SpecFlowProject1.Support.DataForTests.Models;
using SpecFlowProject1.Support.DataForTests;
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
            /*ScenarioContext.Current.Add(KeysForScenCont.nameOfFirstProduct, ProductDetailsMeth.NameOfAddedProduct());
            ScenarioContext.Current.Add(KeysForScenCont.priceOfFirstProduct, ProductDetailsMeth.PriceOfAddedProduct());
            ScenarioContext.Current.Add(KeysForScenCont.quantityOfFirstProduct, ProductDetailsMeth.QuantityOfAddedProduct());
            ScenarioContext.Current.Add(KeysForScenCont.sizeOfFirstProduct, ProductDetailsMeth.SizeOfAddedProduct());
            ScenarioContext.Current.Add(KeysForScenCont.colorOfFirstProduct, ProductDetailsMeth.ColorOfAddedProduct());*/
            ProductDetailsMeth.AddToCart();
           // ScenarioContext.Current.Add(KeysForScenCont.totalPriceOfFirstProduct, ModalWindowMeth.TotalPriceOfAddedProduct());
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

        [Then(@"In cart for (.*) added products displayed correct '([^']*)','([^']*)','([^']*)', '(.*)', '(.*)', '(.*)'")]
        public void ThenInCartForAddedProductsDispyaedCorrect(int p0, string expectedName, string expectedSize, string expectedColor, string expUnitPrice, string expQuantity, string expTotalPrice)
        {
            var actualName = CartPageMeth.AddedToCartProductName(2);
            var actualPrice = CartPageMeth.AddedToCartProductPrice(2);
            var actualSize = CartPageMeth.AddedToCartProductSize(2);
            var actualColor = CartPageMeth.AddedToCartProductColor(2);
            var actualQuantity = CartPageMeth.AddedToCartProductQuantity(2);
            var actualTotalPrice = CartPageMeth.AddedToCartProductTotalPrice(2);
            Assert.IsTrue(expectedName.Contains(actualName));
            Assert.IsTrue(expUnitPrice.Contains(actualPrice));
            Assert.AreEqual(expectedSize, actualSize);
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expQuantity, actualQuantity);
            Assert.AreEqual(expTotalPrice, actualTotalPrice);
            //for second 
            expectedName = (string)ScenarioContext.Current["Name of second product"];
            expectedSize = (string)ScenarioContext.Current["Size of second product"];
            expectedColor = (string)ScenarioContext.Current["Color of second product"];
            expUnitPrice = (string)ScenarioContext.Current["Price for second product"];
            expQuantity = (string)ScenarioContext.Current["Quantity of second product"];
            expTotalPrice = (string)ScenarioContext.Current["Total price of second product"];
            actualName = CartPageMeth.AddedToCartProductName(1);
            actualPrice = CartPageMeth.AddedToCartProductPrice(1);
            actualSize = CartPageMeth.AddedToCartProductSize(1);
            actualColor = CartPageMeth.AddedToCartProductColor(1);
            actualQuantity = CartPageMeth.AddedToCartProductQuantity(1);
            actualTotalPrice = CartPageMeth.AddedToCartProductTotalPrice(1);
            Assert.IsTrue(expectedName.Contains(actualName));
            Assert.IsTrue(expUnitPrice.Contains(actualPrice));
            Assert.AreEqual(expectedSize, actualSize);
            Assert.AreEqual(expectedColor, actualColor);
            Assert.AreEqual(expQuantity, actualQuantity);
            Assert.AreEqual(expTotalPrice, actualTotalPrice);
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
