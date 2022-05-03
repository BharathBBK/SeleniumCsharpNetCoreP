using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NxtAdminSanity.Pages
{
    class AdminLandingPage : Driverhelper
    {
        private IWebDriver _driverHelper;

        public AdminLandingPage(IWebDriver driverHelper)
        {
            _driverHelper = driverHelper;
        }

        IWebElement BtnLogout => _driverHelper.FindElement(By.XPath("//span[contains(text(),'Logout')]"));

        public bool Logout() => BtnLogout.Displayed;

        public void Logoutapp() => BtnLogout.Click();

    }
}
