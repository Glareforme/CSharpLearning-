using PageObjectModel.POM.SetUp;
using PageObjectModel.POM.Methods;

namespace PageObjectModel
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            SetUpTests.CreateBrowser().Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }

        [Test]
        public void Test1()
        {
            RegistrationMeth.OutputRegistrationTitleText();
            RegistrationMeth.OutputHitnText();
            AuthorizeMeth.OutputAuthorizeTitleText();
            AuthorizeMeth.InputInEmailField();
            AuthorizeMeth.InputInPasswordField();
            AuthorizeMeth.CorfirmInput();
        }
        [TearDown]
        public void TearDown()
        {
            SetUpTests.QuitBrowser();
        }
    }
}