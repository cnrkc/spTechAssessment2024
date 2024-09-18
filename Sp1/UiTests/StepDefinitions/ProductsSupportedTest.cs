using OpenQA.Selenium;
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
            rm.ScrollToAdditionalFeratures(driver);
            rm.ClickProductsSupported();

            Assert.That(driver.FindElements(By.XPath("//h3[contains(text(),'There are several types of Product Supported:')]")).Count == 1);
            Assert.That(driver.FindElements(By.XPath("//span[contains(text(),'Cue Sheet / AV Work')]")).Count == 1);
            Assert.That(driver.FindElements(By.XPath("//span[contains(text(),'Recording')]")).Count == 1);
            Assert.That(driver.FindElements(By.XPath("//span[contains(text(),'Bundle')]")).Count == 1);
            Assert.That(driver.FindElements(By.XPath("//span[contains(text(),'Advertisement')]")).Count == 1);
        }

        [TearDownAttribute]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}