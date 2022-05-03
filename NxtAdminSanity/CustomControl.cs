using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NxtAdminSanity
{
    public class CustomControl 
    {

        private IWebDriver Driver;
        

        public CustomControl(IWebDriver driver) {

            Driver = driver;
        
        }

        

        public void combobox(String CtrlName, String InputValue) {
            IWebElement Combo = Driver.FindElement(By.XPath($"//input[@id='{CtrlName}-awed']"));
            Combo.Clear();
            Combo.SendKeys(InputValue);
            System.Threading.Thread.Sleep(3000);
            Driver.FindElement(By.XPath($"//div[@id='{CtrlName}-dropmenu']//li[contains(text(),'{InputValue}')]")).Click();
        }

        public void Entertext(IWebElement webElement, String value) {

            webElement.SendKeys(value);
        }

        public void Click(IWebElement webelement) {

            webelement.Click();
        }

        public void selectbyvalue(IWebElement ele, String value) {

            SelectElement select = new SelectElement(ele);
            select.SelectByValue(value);

        }

        public void selectbyText(IWebElement ele, String text)
        {

            SelectElement select = new SelectElement(ele);
            select.SelectByText(text);

        }

        public void selectbyindex(IWebElement ele, int index)
        {

            SelectElement select = new SelectElement(ele);
            select.SelectByIndex(index);

        }
    }
}
