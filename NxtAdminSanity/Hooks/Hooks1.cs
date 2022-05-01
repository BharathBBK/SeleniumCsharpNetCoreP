using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace NxtAdminSanity.Hooks
{
    [Binding]
    public sealed class Hooks1 : Driverhelper
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Browser closed successfully");
            Driver.Quit();
        }
    }
}
