using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA.Selenium_Basics
{
    class FindElementCommands
    {
        [Test]
        public void RegForm()
        {
            IWebDriver driver = new FirefoxDriver();

            // Launch the ToolsQA WebSite
            driver.Url = ("http://toolsqa.wpengine.com/Automation-practice-form/");

            // Type Name in the FirstName text box      
            driver.FindElement(By.Name("firstname")).SendKeys("Lakshay");

            //Type LastName in the LastName text box
            driver.FindElement(By.Name("lastname")).SendKeys("Sharma");

            // Click on the Submit button
            driver.FindElement(By.Id("submit")).Click();
        }
    }
}
