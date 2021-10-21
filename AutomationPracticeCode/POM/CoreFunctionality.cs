using AutomationPracticeCode.Locators;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeCode.POM
{
    public class CoreFunctionality
    {
        private IWebDriver _driver;

        private IWebElement searchBar;
        private IWebElement searchIcon;

        private IWebElement emailNewsletter;

        public CoreFunctionality(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void Search(string product)
        {
            searchBar = _driver.FindElement(By.Id(MainConstants.searchBarId));
            searchBar.SendKeys(product);
            searchIcon = _driver.FindElement(By.CssSelector(MainConstants.searchIconCss));
            searchIcon.Click();
        }

        public void SendANewsletter(string email)
        {
            emailNewsletter = _driver.FindElement(By.Id(MainConstants.newsletterId));
            emailNewsletter.SendKeys(email);


        }
    }
}


