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

        private IWebDriver driver;

        [SetUp()]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Manage().Window.Maximize();
            driver.Url = MainConstants.url;
        }

        [Test(Description = "Search a product.")]
        public void SearchProduct()
        {
            CoreFunctionality core = new CoreFunctionality(driver);
            core.Search("blouse");
        }

        [Test(Description = "Validate the user is able to sign in successfully.")]
        public void ValidateSignIn()
        {
            HomePage homePage = new HomePage(driver);
            homePage.SignIn();
        }

        [Test(Description = "The user is able to edit his/her personal information from 'My Account' module")]
        public void EditMyPersonalInformation()
        {
            HomePage homePage = new HomePage(driver);
            homePage.SignIn();
            MyAccountPage myAccount = new MyAccountPage(driver);
            myAccount.MyPersonalInformation();
            PersonalInformationPage personalInformation = new PersonalInformationPage(driver);
            personalInformation.EditMandatoryFieldsOnPersonalInformationPage("Rey", "Hernández", "demo@mail.com", "1234");
        }

        [Test(Description = "Sign out sucessfully")]
        public void signOutTheAccount()
        {
            ValidateSignIn();
            HomePage homePage = new HomePage(driver);
            homePage.SignOut();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        } 
    }
}
