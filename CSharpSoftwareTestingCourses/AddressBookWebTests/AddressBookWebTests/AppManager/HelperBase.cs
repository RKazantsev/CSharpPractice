using OpenQA.Selenium;

namespace AddressBookWebTests
{
    public class HelperBase
    {
        protected IWebDriver driver;
        protected AppManager appManager;

        public HelperBase(AppManager appManager)
        {
            this.appManager = appManager;
            driver = appManager.Driver;
        }
    }
}