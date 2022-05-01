using NUnit.Framework;
using NxtAdminSanity.Pages;
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
                Console.WriteLine("Cookie is not displayed");
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
            Driver.Navigate().GoToUrl("https://nxt-stage.alogent.com/admin/login");

            Driver.FindElement(By.XPath("//label[contains(text(),'Username')]/following-sibling::input")).SendKeys("implementations");
            Driver.FindElement(By.XPath("//input[@type='password']")).SendKeys("password123");
            Driver.FindElement(By.XPath("//button[contains(text(),'Login')]")).Click();


        }
        [Test]
        public void LoginTest() {

            Driver.Navigate().GoToUrl("https://nxt-stage.alogent.com/admin/login");
            System.Threading.Thread.Sleep(5000);

            LoginPage Lpage = new LoginPage();
            AdminLandingPage ALPage = new AdminLandingPage();

            Lpage.EnterUsername("implementations");
            Lpage.EnterPassword("password123");
            Lpage.ClickLogin();
            System.Threading.Thread.Sleep(5000);
            Assert.That(ALPage.Logout, Is.True, "Logout Button displayed on Landing screen");
            ALPage.Logoutapp();

        }
    }
}