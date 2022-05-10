using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NxtAdminSanity.Pages
{
    class EndUserManagement_ManageUser
    {

        private IWebDriver Driver;

        public EndUserManagement_ManageUser(IWebDriver _driver) {

            Driver = _driver;
        }

        IWebElement EUManagement => Driver.FindElement(By.XPath("//button[contains(text(),' End User Management ')]"));
        IWebElement MUser => Driver.FindElement(By.XPath("//a[contains(text(),' Manage User')]"));
        IWebElement Input => Driver.FindElement(By.Id("searchInput"));
        IWebElement Search => Driver.FindElement(By.XPath("//button[contains(text(),'Search')]"));
        IWebElement results => Driver.FindElement(By.XPath("//tr[@class='clickable']/td[1]"));
        IWebElement username => Driver.FindElement(By.XPath("//div[@class='col-sm-9']"));

        public void EndUserManagement() => EUManagement.Click();
        public void ManageUser() => MUser.Click();
        public void EnterInput(String username) => Input.SendKeys(username);
        public void SearchUser() => Search.Click();
        public void SelectResults() => results.Click();
        public bool ValidateUsername() => username.Displayed;
        public String Usernameval() => username.Text;


    }
}
