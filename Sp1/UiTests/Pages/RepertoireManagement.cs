using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace Sp1.UiTests.Pages
{
    public class RepertoireManagement
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Additional Features')]")]
        IWebElement additionalfeatures;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Products Supported')]")]
        IWebElement productssupported;

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'There are several types of Product Supported:')]")]
        IWebElement supportedproductsHeader;

        public RepertoireManagement(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ScrollToAdditionalFeratures(IWebDriver driver)
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(additionalfeatures);
            actions.Perform();
        }

        public void ClickProductsSupported()
        {
            productssupported.Click();
        }

    }
}