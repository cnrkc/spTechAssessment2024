using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Sp1.UiTests.Pages
{
    public class RepertoireManagement
    {
        private readonly IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//h2[contains(text(),'Additional Features')]")]
        readonly IWebElement additionalfeatures;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Products Supported')]")]
        readonly IWebElement productssupported;

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'There are several types of Product Supported:')]")]
        readonly IWebElement supportedproductsHeader;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Cue Sheet / AV Work')]")]
        readonly IWebElement cuesheet;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Recording')]")]
        readonly IWebElement recording;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Bundle')]")]
        readonly IWebElement bundle;

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Advertisement')]")]
        readonly IWebElement advertisment;

        public RepertoireManagement(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void ClickProductsSupported()
        {
            productssupported.Click();
        }

        public int CountHeader(IWebDriver driver)
        {
            return driver.FindElements(By.XPath("//h3[contains(text(),'There are several types of Product Supported:')]")).Count;
        }

        public int CountCueSheet(IWebDriver driver)
        {
            return driver.FindElements(By.XPath("//span[contains(text(),'Cue Sheet / AV Work')]")).Count;
        }

        public int CountRecording(IWebDriver driver)
        {
            return driver.FindElements(By.XPath("//span[contains(text(),'Recording')]")).Count;
        }

        public int CountBundle(IWebDriver driver)
        {
            return driver.FindElements(By.XPath("//span[contains(text(),'Bundle')]")).Count;
        }
        public int CountAdvertisment(IWebDriver driver)

        {
            return driver.FindElements(By.XPath("//span[contains(text(),'Advertisement')]")).Count;
        }

        public Boolean CheckProductsHeaderDisplayed()
        {
            if (supportedproductsHeader.Displayed != true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CheckCueSheetDisplayed()
        {
            if (cuesheet.Displayed != true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CheckRecordingDisplayed()
        {
            if (recording.Displayed != true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public Boolean CheckBundleDisplayed()
        {
            if (bundle.Displayed != true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean CheckAdvertisementDisplayed()
        {
            if (advertisment.Displayed != true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}