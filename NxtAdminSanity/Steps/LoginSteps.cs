using NUnit.Framework;
using NxtAdminSanity.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NxtAdminSanity.Steps
{
   [Binding]
    public class LoginSteps : Driverhelper
    {

        LoginPage Lpage = new LoginPage();
        AdminLandingPage ALPage = new AdminLandingPage();

        [Given(@"user is on login screen")]
        public void GivenUserIsOnLoginScreen()
        {
            Driver.Navigate().GoToUrl("https://nxt-stage.alogent.com/admin/login");
        }

        [Given(@"Enter valid username and Password")]
        public void GivenEnterValidUsernameandPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            Lpage.EnterUsername(data.Username);
            Lpage.EnterPassword(data.Password);
        }

        [When(@"user click on login button")]
        public void WhenUserClickOnLoginButton()
        {
            Lpage.ClickLogin();
            System.Threading.Thread.Sleep(5000);

        }

        [Then(@"user should routed to admin application")]
        public void ThenUserShouldRoutedToAdminApplication()
        {
            Assert.That(ALPage.Logout, Is.True, "Logout Button displayed on Landing screen");

            ALPage.Logoutapp();

            System.Threading.Thread.Sleep(5000);
        }



    }
}
