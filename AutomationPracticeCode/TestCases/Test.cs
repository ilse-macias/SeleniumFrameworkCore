using AutomationPracticeCode.POM;
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

        [Test(Description = "The user is able to edit his/her personal information from 'My Account' module")]
        public void EditMyPersonalInformation()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.SignIn();
            MyAccountPage myAccount = new MyAccountPage(_driver);
            myAccount.MyPersonalInformation();
            PersonalInformationPage personalInformation = new PersonalInformationPage(_driver);
            personalInformation.EditMandatoryFieldsOnPersonalInformationPage("Rey", "Hernández", "demo@mail.com", "1234");
        }

        [Test(Description = "Sign out sucessfully")]
        public void signOutTheAccount()
        {
            ValidateSignIn();
            HomePage homePage = new HomePage(_driver);
            homePage.SignOut();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
            _driver.Quit();
        } 
    }
}
