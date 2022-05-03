using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NxtAdminSanity.Hooks
{
    [Binding]
    public sealed class Hooks1 
    {

        private Driverhelper _driverHelper;

        public Hooks1(Driverhelper driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driverHelper.Driver = new ChromeDriver();
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Browser closed successfully");
            _driverHelper.Driver.Quit();
        }
    }
}
