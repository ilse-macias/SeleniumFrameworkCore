using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeCode.POM
{
    public class MyAccountPage
    {
        private IWebDriver _driver;
        private IWebElement accountNameButton;
        private IWebElement myPersonalInformationButton;

        public MyAccountPage(IWebDriver _driver)
        {
            this._driver = _driver;
        }
        public void MyPersonalInformation()
        {
            accountNameButton = _driver.FindElement(By.ClassName("account"));
            accountNameButton.Click();

            myPersonalInformationButton = _driver.FindElement(By.CssSelector("#center_column > div > div:nth-child(1) > ul > li:nth-child(4) > a"));
            myPersonalInformationButton.Click();
        }
    }
}
