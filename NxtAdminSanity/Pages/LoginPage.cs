using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NxtAdminSanity.Pages
{
    class LoginPage 
    {
        private IWebDriver _driverHelper;

        public LoginPage(IWebDriver driverHelper)
        {
            _driverHelper = driverHelper;
        }

        IWebElement TextUsername => _driverHelper.FindElement(By.XPath("//label[contains(text(),'Username')]/following-sibling::input"));
        IWebElement TextPassword => _driverHelper.FindElement(By.XPath("//input[@type='password']"));
        IWebElement BtnLogin => _driverHelper.FindElement(By.XPath("//button[contains(text(),'Login')]"));

        public void EnterUsername(String uname) => TextUsername.SendKeys(uname);
        public void EnterPassword(String Password) => TextPassword.SendKeys(Password);
        public void ClickLogin() => BtnLogin.Click();


    }
}
