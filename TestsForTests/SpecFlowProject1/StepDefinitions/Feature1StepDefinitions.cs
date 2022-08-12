using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class Feature1StepDefinitions
    {
        [Given(@"Open website page")]
        public void GivenOpenWebsitePage()
        {
            throw new PendingStepException();
        }

        [When(@"Enter '([^']*)' in search input field")]
        public void WhenEnterInSearchInputField(string summer)
        {
            throw new PendingStepException();
        }

        [When(@"Click on confirm search button")]
        public void WhenClickOnConfirmSearchButton()
        {
            throw new PendingStepException();
        }


        [Then(@"In inscription '([^']*)' dispayed '([^']*)'")]
        public void ThenInInscriptionDispayed(string search, string summer)
        {
            throw new PendingStepException();
        }

        [When(@"Select option '([^']*)' in dropdown")]
        public void WhenSelectOptionInDropdown(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"All element sorted with selected option")]
        public void ThenAllElementSortedWithSelectedOption()
        {
            throw new PendingStepException();
        }

        [When(@"Remember name and price of '([^']*)'")]
        public void WhenRememberNameAndPriceOf(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Add '([^']*)' to busket")]
        public void WhenAddToBusket(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Open busket")]
        public void WhenOpenBusket()
        {
            throw new PendingStepException();
        }

        [Then(@"Verify added to busset correspond remembered name and price of '([^']*)'")]
        public void ThenVerifyAddedToBussetCorrespondRememberedNameAndPriceOf(string p0)
        {
            throw new PendingStepException();
        }
        [When(@"Click on '([^']*)' button for '([^']*)' found")]
        public void WhenClickOnButtonForFound(string more, string p1)
        {
            throw new PendingStepException();
        }

        [When(@"Select in details for product")]
        public void WhenSelectInDetailsForProduct(Table table)
        {
            throw new PendingStepException();
        }

        [When(@"Click Add to cart on '([^']*)' product page")]
        public void WhenClickAddToCartOnProductPage(string more)
        {
            throw new PendingStepException();
        }

        [Then(@"Message '([^']*)' displayed in modal window")]
        public void ThenMessageDisplayedInModalWindow(string p0)
        {
            throw new PendingStepException();
        }
        [When(@"Click '([^']*)' in modal window")]
        public void WhenClickInModalWindow(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"For (.*) added products dispyaed correct '([^']*)','([^']*)','([^']*)', '([^']*)', '([^']*)', '([^']*)'")]
        public void ThenForAddedProductsDispyaedCorrect(int p0, string name, string size, string color, string p4, string p5, string p6)
        {
            throw new PendingStepException();
        }

        [When(@"Delete '([^']*)' from basket")]
        public void WhenDeleteFromBasket(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"In busket list only '([^']*)' left")]
        public void ThenInBusketListOnlyLeft(string blouse)
        {
            throw new PendingStepException();
        }

    }
}
