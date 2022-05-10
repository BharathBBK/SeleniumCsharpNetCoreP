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
    class ManageUserSteps
    {
        private Driverhelper Driver;

        LoginPage Lpage;
        EndUserManagement_ManageUser EUManage;

        public ManageUserSteps(Driverhelper _Driver) {

            Driver = _Driver;

            Lpage = new LoginPage(Driver.Driver);
            EUManage = new EndUserManagement_ManageUser(Driver.Driver);
        
        }

        [Given(@"User click on EndUserManagement menu")]
        public void GivenUserClickOnEndUserManagementMenu()
        {
            EUManage.EndUserManagement();
        }

        [Given(@"User click on ManageUser submenu")]
        public void GivenUserClickOnManageUserSubmenu()
        {
            EUManage.ManageUser();
        }

        [Given(@"enter input to get End user")]
        public void GivenEnterInputToGetEndUser(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            EUManage.EnterInput(data.input);
        }

        [Given(@"click on search button")]
        public void GivenClickOnSearchButton()
        {
            System.Threading.Thread.Sleep(5000);
            EUManage.SearchUser();
        }

        [Given(@"click on filtered results")]
        public void GivenClickOnFilteredResults()
        {
            System.Threading.Thread.Sleep(5000);
            EUManage.SelectResults();
        }

        [Then(@"validatate input and results are matching")]
        public void ThenValidatateInputAndResultsAreMatching()
        {
            System.Threading.Thread.Sleep(5000);
            Assert.That(EUManage.ValidateUsername, Is.True, "Username is displayed as expected");
            Console.WriteLine(EUManage.Usernameval());
        }
    }
}
