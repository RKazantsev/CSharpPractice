using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AddressBookWebTests
{
    public class AppManager
    {
        protected IWebDriver driver;
        protected string baseURL;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;        

        public AppManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/";
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);            
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }
        }

        public string BaseURL
        {
            get
            {
                return baseURL;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }
        
        public NavigationHelper Navigator
        {
            get
            {
                return navigationHelper;
            }
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }

        public ContactHelper Contact
        {
            get
            {
                return contactHelper;
            }
        }        

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    }   
}