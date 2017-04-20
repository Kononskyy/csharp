using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.test.webdriver.Tests.massage
{
    class MassageTherapyRegistrationSmokeTests
    {
        IWebDriver driver;
        String baseUrl = "http://moncherleo.github.io";
        const String thankYouText = "Thank You!";

        By firstName = By.XPath(".//input[contains(@id,'first')]");
        By middleName = By.XPath(".//input[@id='middle_64']") ;
        By lastName = By.XPath(".//*[@data-type='control_fullname']//*[contains(text(),'Last Name')]/preceding-sibling::input");
        By streetAddress = By.XPath(".//*[@class='form-address-table']//*[contains(@name,'addr_line1')]");
        By streetAddressLine2 = By.XPath(".//*[@class='form-address-table']//*[contains(@name,'addr_line2')]");
        By city = By.CssSelector(".form-address-table input[id$='city']");
        By stateProvince = By.CssSelector(".form-address-table .form-address-state");
        By postalZipCode = By.CssSelector(".form-address-table .form-address-postal");
        By countryDDL = By.CssSelector(".form-address-table .form-address-country"); // there are all basic locators
        By submitSubmit = By.CssSelector("*[type='submit']");
        By thanks = By.XPath("//span[contains(text(),'Thank You!')]");

        [SetUp]
        public void SetUp() // pre-condition
        {
            var options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(options); //open new window of FF
            driver.Manage().Window.Maximize(); //open for full scrin
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(baseUrl);

        }

        [TearDown]
        public void TearDowm()
        {
            driver.Quit();
        }

        [Test]
        public void FullNameWithAdess()
        {
            driver.FindElement(firstName).SendKeys("Sasha");
            driver.FindElement(middleName).SendKeys("Vasilych");
            driver.FindElement(lastName).SendKeys("K");
            driver.FindElement(streetAddress).SendKeys("Zakr");
            driver.FindElement(streetAddressLine2).SendKeys("93");
            driver.FindElement(city).SendKeys("Kyiv");
            driver.FindElement(stateProvince).SendKeys("Troeshchina");
            driver.FindElement(postalZipCode).SendKeys("02232");

            IWebElement select = driver.FindElement(countryDDL);
            SelectElement dropDown = new SelectElement(select);
            dropDown.SelectByText("Ukraine");

            driver.FindElement(submitSubmit).Click();
            Assert.AreEqual(thankYouText, driver.FindElement(thanks).Text);

        }
    }
}
