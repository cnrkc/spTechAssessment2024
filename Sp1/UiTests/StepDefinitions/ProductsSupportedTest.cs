using OpenQA.Selenium.Chrome;
using Sp1.UiTests.Pages;

namespace Sp1.UiTests.StepDefinitions
{
    public class ProductsSupportedTest
    {
        private ChromeDriver driver;

        [SetUp]
        public void InitScript()
        {
            var options = new ChromeOptions();
            options.AddExcludedArgument("--disable-search-engine-choice-screen");
            options.AddExcludedArgument("--start-maximized");

            driver = new ChromeDriver(options);
        }


        [Test]
        public void Test()
        {
            MainNavigation nav = new MainNavigation(driver);
            driver.Navigate().GoToUrl("https://www.matchingengine.com/");

            nav.ClickRepetoireManagementModule(driver);

            RepertoireManagement rm = new RepertoireManagement(driver);
            rm.ClickProductsSupported();

            Assert.That(rm.CountHeader(driver) == 1);
            Assert.That(rm.CountCueSheet(driver) == 1);
            Assert.That(rm.CountRecording(driver) == 1);
            Assert.That(rm.CountBundle(driver) == 1);
            Assert.That(rm.CountAdvertisment(driver) == 1);

            Assert.That(rm.CheckProductsHeaderDisplayed(), Is.EqualTo(true));
            Assert.That(rm.CheckCueSheetDisplayed(), Is.EqualTo(true));
            Assert.That(rm.CheckRecordingDisplayed(), Is.EqualTo(true));
            Assert.That(rm.CheckBundleDisplayed(), Is.EqualTo(true));
            Assert.That(rm.CheckAdvertisementDisplayed(), Is.EqualTo(true));
        }

        [TearDownAttribute]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}