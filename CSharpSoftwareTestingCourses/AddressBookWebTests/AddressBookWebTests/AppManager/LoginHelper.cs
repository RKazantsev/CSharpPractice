using OpenQA.Selenium;

namespace AddressBookWebTests
{   
    public class LoginHelper : HelperBase
    {
        public LoginHelper(AppManager appManager): base(appManager) { }
        
        public void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.UserName);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }        
    }
}