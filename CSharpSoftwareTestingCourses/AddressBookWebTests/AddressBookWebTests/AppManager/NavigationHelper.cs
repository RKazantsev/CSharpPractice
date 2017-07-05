﻿using OpenQA.Selenium;

namespace AddressBookWebTests
{   
    public class NavigationHelper: HelperBase
    {       
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL): base(driver)
        {          
            this.baseURL = baseURL;
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