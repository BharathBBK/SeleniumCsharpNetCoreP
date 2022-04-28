using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NxtAdminSanity.Pages
{
    class LoginPage : Driverhelper
    {
        IWebElement TextUsername => Driver.FindElement(By.XPath("//label[contains(text(),'Username')]/following-sibling::input"));
        IWebElement TextPassword => Driver.FindElement(By.XPath("//input[@type='password']"));
        IWebElement BtnLogin => Driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));

        public void EnterUsername(String uname) => TextUsername.SendKeys(uname);
        public void EnterPassword(String Password) => TextPassword.SendKeys(Password);
        public void ClickLogin() => BtnLogin.Click();


    }
}
