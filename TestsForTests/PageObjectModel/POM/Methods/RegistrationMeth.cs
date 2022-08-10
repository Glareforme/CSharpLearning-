using OpenQA.Selenium;
using PageObjectModel.POM.Locators;
using PageObjectModel.POM.SetUp;

namespace PageObjectModel.POM.Methods
{
    internal class RegistrationMeth
    {
        public static void OutputRegistrationTitleText() => SetUpTests.ReturnText(RegstrationLoc.ModuleTitle);
        public static void OutputHitnText() => SetUpTests.ReturnText(RegstrationLoc.HintText);
    }
}
