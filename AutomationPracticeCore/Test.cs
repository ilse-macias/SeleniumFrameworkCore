﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AutomationPracticeCore
{
    [TestFixture()]
    public class Test
    {

        private IWebDriver _driver;

        [Test()]
        public void TestCase()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Cookies.DeleteAllCookies();
            _driver.Manage().Window.Maximize();
            _driver.Url = "http://automationpractice.com/index.php";

            _driver.Close();
            _driver.Quit();
        }
    }
}
