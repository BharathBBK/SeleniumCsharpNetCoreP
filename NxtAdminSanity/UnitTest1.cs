using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NxtAdminSanity
{
    public class Tests : Driverhelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("setup");

            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            IWebElement coocki = Driver.FindElement(By.Id("btnCookie"));

            if (coocki.Displayed)
            {
                coocki.Click();
            }
            else {
                Console.WriteLine("Cookie not displayed");
            }

            CustomControl.Entertext(Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$Meal']")), "t");
            System.Threading.Thread.Sleep(5000);
            CustomControl.Click(Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_Meal-dropmenu']/div[2]/ul/li[contains(text(),'Tomato')]")));
            CustomControl.Click(Driver.FindElement(By.XPath("//div[contains(text(),'Grains')]")));
            CustomControl.combobox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            CustomControl.selectbyvalue(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")),"185");
            CustomControl.selectbyText(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Lettuce");
            CustomControl.selectbyindex(Driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), 2);
            Console.WriteLine("New line inserted");
            Assert.Pass();
        }
        [Test]
        public void Test2() {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            IWebElement coocki = Driver.FindElement(By.Id("btnCookie"));

            if (coocki.Displayed)
            {
                coocki.Click();
            }
            else
            {
                Console.WriteLine("Cookie not displayed");
            }

            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$Meal']")).SendKeys("t");

            IList<IWebElement> ele = Driver.FindElements(By.XPath("//div[@id='ContentPlaceHolder1_Meal-dropmenu']/div[2]/ul/li"));

            foreach (IWebElement nele in ele) {

                nele.Click();

                System.Threading.Thread.Sleep(3000);

                Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$Meal']")).SendKeys("t");
            }
            

        }
    }
}