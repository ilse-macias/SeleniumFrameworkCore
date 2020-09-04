using System.Threading;
using OpenQA.Selenium;

namespace AutomationPracticeCore.POM
{
    public class HomePage
    {
        public IWebDriver _driver;


        private IWebElement searchBar;
        private IWebElement searchIcon;

        private IWebElement signInButton;

        private IWebElement emailAddressField;
        private IWebElement passwordField;

        public HomePage(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void Search()
        {
            searchBar = _driver.FindElement(By.Id("search_query_top"));
            searchBar.SendKeys("blouse");
            searchIcon = _driver.FindElement(By.ClassName("btn btn-default button-search"));
        }
        public void SignIn()
        {
            signInButton = _driver.FindElement(By.ClassName("login"));
            signInButton.Click();
            Thread.Sleep(3000);

            emailAddressField = _driver.FindElement(By.Id("email"));
            emailAddressField.SendKeys("demo@mailinator.com");

            passwordField = _driver.FindElement(By.Id("passwd"));
            passwordField.SendKeys("12345");

        }
       
    }
}
