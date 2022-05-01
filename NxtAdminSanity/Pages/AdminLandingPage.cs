using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NxtAdminSanity.Pages
{
    class AdminLandingPage : Driverhelper
    {

        IWebElement BtnLogout => Driver.FindElement(By.XPath("//span[contains(text(),'Logout')]"));

        public bool Logout() => BtnLogout.Displayed;

        public void Logoutapp() => BtnLogout.Click();

    }
}
