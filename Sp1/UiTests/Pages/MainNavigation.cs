using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sp1.UiTests.Pages
{
    public class MainNavigation
    {
        private IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//div[@id='navMenu']/div[1]/div[1]/a")]
        IWebElement _modules;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Repertoire Management Module')]")]
        IWebElement _repetoiremanagementmodule;

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Additional Features')]")]
        IWebElement _additionalfeatures;



        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement _searchbtn;

        public MainNavigation(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickRepetoireManagementModule(IWebDriver driver)
        {
            _modules.Click();
            _repetoiremanagementmodule.Click();

        }
    }
}