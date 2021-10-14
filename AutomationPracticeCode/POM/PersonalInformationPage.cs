using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPracticeCode.POM
{
    public class PersonalInformationPage
    {
        private IWebDriver _driver;
        private IWebElement firstNameField;
        private IWebElement lastNameField;
        private IWebElement emailAddressField;
        private IWebElement currentPasswordField;
        private IWebElement saveButton;

        public PersonalInformationPage(IWebDriver _driver)
        {
            this._driver = _driver;
        }

        public void EditMandatoryFieldsOnPersonalInformationPage(string firstName, string lastName, string email, string currentPassword)
        {
            firstNameField = _driver.FindElement(By.Id("firstname"));
            firstNameField.SendKeys(firstName);

            lastNameField = _driver.FindElement(By.Id("lastname"));
            lastNameField.SendKeys(lastName);

            emailAddressField = _driver.FindElement(By.Id("email"));
            emailAddressField.SendKeys(email);

            currentPasswordField = _driver.FindElement(By.Id("old_passwd"));
            currentPasswordField.SendKeys(currentPassword);

            saveButton = _driver.FindElement(By.Name("submitIdentity"));
            saveButton.Click();
        }
    }
}
