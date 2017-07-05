using OpenQA.Selenium;

namespace AddressBookWebTests
{   
    public class NavigationHelper: HelperBase
    {       
        private string baseURL;

        public NavigationHelper(AppManager appManager) : base(appManager)
        {          
            baseURL = appManager.BaseURL;
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook/");
        }

        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }        
    }
}