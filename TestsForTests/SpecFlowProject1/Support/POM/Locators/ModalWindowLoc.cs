using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1.Support.POM.Locators
{
    internal class ModalWindowLoc
    {
        internal static By successfullAddingText = By.XPath("(//h2[contains(text(), '')])[1]");
        internal static By continueShoping = By.XPath("//span[@title='Continue shopping']");
        internal static By moveToCart = By.XPath("//a[@title='Proceed to checkout']");
        internal static By closeModalWindow = By.XPath("//span[@title='Close window']");
        internal static By totalPriceOfProduct = By.Id("layer_cart_product_price"); 
    }
}
