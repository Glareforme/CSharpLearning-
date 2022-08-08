using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium.locators
{
    internal class Locators
    {
        const string ChangeToListButton = "//li[@id='list']"; 
        const string DressesButton = "(//a[@title='Dresses'])[2]";
        const string SearchTitle = "//span[@class='lighter']";
        const string SearchByDropDown = "//div[@id='uniform-selectProductSort']";
        const string SelectInDropDownZ_A = "//option[text()='Product Name: Z to A']";
        const string AddToCartButton = "(//a[@title='Add to cart'])[2]";
    }
}
