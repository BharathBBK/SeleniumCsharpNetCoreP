using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NxtAdminSanity
{
    public class CustomControl : Driverhelper
    {

        public static void combobox(String CtrlName, String InputValue) {

            IWebElement Combo = Driver.FindElement(By.XPath($"//input[@id='{CtrlName}-awed']"));

            Combo.Clear();
            Combo.SendKeys(InputValue);

            System.Threading.Thread.Sleep(3000);

            Driver.FindElement(By.XPath($"//div[@id='{CtrlName}-dropmenu']//li[contains(text(),'{InputValue}')]")).Click();


        }

    }
}
