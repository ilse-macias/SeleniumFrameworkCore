using System.Threading;
using AutomationPracticeCode.Constants;
using AutomationPracticeCode.Locators;
using AutomationPracticeCore.Constants;
using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationPracticeCore.POM
{
    public class HomePage
    {
        private IWebDriver _driver;

        private IWebElement searchBar;
        private IWebElement searchIcon;

        private IWebElement signInButton;

        private IWebElement emailAddressField;
        private IWebElement passwordField;

        private IWebElement signOutButton;

        private IWebElement greenSignInButton;

        public HomePage(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        //public void Search()
        //{
        //    searchBar = _driver.FindElement(By.Id(MainConstants.searchBarId));
        //    searchBar.SendKeys("blouse");
        //    searchIcon = _driver.FindElement(By.CssSelector(MainConstants.searchIconCss));
        //}

        public void SignIn()
        {
            signInButton = _driver.FindElement(By.ClassName(HomePageConstants.signInButtonClass));
            signInButton.Click();
            Thread.Sleep(3000);

            emailAddressField = _driver.FindElement(By.Id(MyAccontConstants.EmailTextBoxId));
            emailAddressField.SendKeys(MyAccontConstants.EmailInput);

            passwordField = _driver.FindElement(By.Id(MyAccontConstants.PasswordTextBoxId));
            passwordField.SendKeys(MyAccontConstants.PasswordInput);

            greenSignInButton = _driver.FindElement(By.Id(MyAccontConstants.SubmitButtonId));
            greenSignInButton.Click();
        }

        public void SignOut()
        {
            signOutButton = _driver.FindElement(By.ClassName("logout"));
            signOutButton.Click();

            Assert.AreEqual("Sign out", signOutButton.Text);
        }
       

        public void ViewAProduct()
        {

        }
    }
}
