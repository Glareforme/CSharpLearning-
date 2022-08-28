using SpecFlowProject1.Drivers;
using SpecFlowProject1.Support.DataForTests;

namespace SpecFlowProject1.Support.Hooks
{
    [Binding]
    public sealed class HooksForChrome
    {
        [BeforeScenario("@chrome")]
        public static void BeforeScenario() => DriverForBrowser.GetDriver().Navigate().GoToUrl(BaseData.baseUrl);

        [AfterScenario("@chrome")]
        public static void AfterScenario() => DriverForBrowser.CleanDriver();

        [AfterTestRun(Order = 1)]
        public static void EndOfTests()
        {
            DriverForBrowser.CloseDriver();
        }
    }
}