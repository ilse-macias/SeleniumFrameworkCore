using AutomationPracticeCode.Locators;
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

        private IWebDriver EmailTextBoxId;

        [SetUp()]
        public void SetUp()
        {
            EmailTextBoxId = new ChromeDriver();
            EmailTextBoxId.Manage().Cookies.DeleteAllCookies();
            EmailTextBoxId.Manage().Window.Maximize();
            EmailTextBoxId.Url = MainConstants.url;
        }

        [Test()]
        public void SearchProduct()
        {
            HomePage homePage = new HomePage(EmailTextBoxId);
            homePage.Search();
        }

        [Test()]
        public void ValidateSignIn()
        {
            HomePage homePage = new HomePage(EmailTextBoxId);
            homePage.SignIn();
        }

        [Test(Description = "The user is able to edit his/her personal information from 'My Account' module")]
        public void EditMyPersonalInformation()
        {
            HomePage homePage = new HomePage(EmailTextBoxId);
            homePage.SignIn();
            MyAccountPage myAccount = new MyAccountPage(EmailTextBoxId);
            myAccount.MyPersonalInformation();
            PersonalInformationPage personalInformation = new PersonalInformationPage(EmailTextBoxId);
            personalInformation.EditMandatoryFieldsOnPersonalInformationPage("Rey", "Hernández", "demo@mail.com", "1234");
        }

        [Test(Description = "Sign out sucessfully")]
        public void signOutTheAccount()
        {
            ValidateSignIn();
            HomePage homePage = new HomePage(EmailTextBoxId);
            homePage.SignOut();
        }

        [TearDown]
        public void TearDown()
        {
            EmailTextBoxId.Close();
            EmailTextBoxId.Quit();
        } 
    }
}
