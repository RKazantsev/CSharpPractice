using System;
using OpenQA.Selenium;

namespace AddressBookWebTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(AppManager appManager) : base(appManager) { }

        public GroupHelper Create(GroupData group)
        {
            appManager.Navigator.GoToGroupsPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        internal GroupHelper Remove(int indexGroup)
        {
            appManager.Navigator.GoToGroupsPage();
            SelectGroup(indexGroup);
            RemoveGroup(indexGroup);
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
            return this;
        }

        public GroupHelper RemoveGroup(int indexGroup)
        {
            driver.FindElement(By.XPath("(//input[@name='delete'])[" + indexGroup + "]")).Click();
            return this;
        }

        public GroupHelper SelectGroup(int indexGroup)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + indexGroup + "]")).Click();
            return this;
        }
    }
}