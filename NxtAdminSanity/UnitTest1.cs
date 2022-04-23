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

            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$Meal']")).SendKeys("t");

            System.Threading.Thread.Sleep(5000);

            Console.WriteLine(Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_Meal-dropmenu']/div[2]/ul/li[contains(text(),'Tomato')]")).Text);

            Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_Meal-dropmenu']/div[2]/ul/li[contains(text(),'Tomato')]")).Click();

            Driver.FindElement(By.XPath("//div[contains(text(),'Grains')]")).Click();

            CustomControl.combobox("ContentPlaceHolder1_AllMealsCombo", "Almond");
           

            Console.WriteLine("line1");
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