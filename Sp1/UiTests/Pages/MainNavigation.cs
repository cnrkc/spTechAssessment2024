using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sp1.UiTests.Pages
{
    public class MainNavigation
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div[@id='navMenu']/div[1]/div[1]/a")]
        readonly IWebElement modules;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Repertoire Management Module')]")]
        readonly IWebElement repetoiremanagementmodule;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Repertoire Management Module')]")]

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Additional Features')]")]
        readonly IWebElement additionalfeatures;


        [FindsBy(How = How.Name, Using = "btnK")]
        private IWebElement searchbtn;

        public MainNavigation(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickRepetoireManagementModule(IWebDriver driver)
        {
            modules.Click();
            repetoiremanagementmodule.Click();

        }
    }
}