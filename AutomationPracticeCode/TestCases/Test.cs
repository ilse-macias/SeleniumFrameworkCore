using AutomationPracticeCore.POM;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationPracticeCore
{
    public class Test
    {

        private IWebDriver _driver;

        [SetUp()]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://automationpractice.com/index.php";
        }

        [Test()]
        public void SearchProduct()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.Search();
        }

        [Test()]
        public void ValidateSignIn()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.SignIn();
        }

        [Test]
        public void EditMyPersonalInformation()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.SignIn();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        } 
    }
}
