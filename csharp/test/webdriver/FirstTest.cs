using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace csharp.test.webdriver
{
    
   class FirstTest

   {
       IWebDriver driver;

       [SetUp]
       public void SetUp()
       {
           var options = new FirefoxOptions();
           options.BrowserExecutableLocation = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
           driver = new FirefoxDriver(options);
       }

       [TearDown]
       public void TearDown()
       {
           driver.Quit();
       }


       [Test]
       public void MyFirstTest()
       {
           driver.Navigate().GoToUrl("https://google.com");
           IWebElement query = driver.FindElement(By.Name("q")); //looking for "q" element and connect with them
           //IWebElement query = driver.FindElement(By.Name("login"));
           query.SendKeys("Cheese"); // send Cheese word to q element
           //IWebElement query2 = driver.FindElement(By.Name("pass"));
            //query2.SendKeys("04081988");
           query.Submit(); //send table via POST method to server
           Thread.Sleep(10000); //dangerous hack
           ReadOnlyCollection<IWebElement> webElents;
           webElents = driver.FindElements(By.CssSelector(".r>a"));
           Assert.True(webElents.Count > 0);           
           //Thread.Sleep(1000);
       }
      /*
    [TestFixture]

    class BasicTestSuite
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            var options = new FirefoxOptions();

            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\firefox.exe";

            driver = new FirefoxDriver(options);
        }

        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }

        [Test]

        public void MyFirstSeleniumTest()
        {

            driver.Navigate().GoToUrl("https://google.com");
            IWebElement query = driver.FindElement(By.Name("q"));
            query.SendKeys("Cheese");
            query.Submit();
            Thread.Sleep(10000); //dangerous hack
            ReadOnlyCollection<IWebElement> webElements;
            webElements = driver.FindElements(By.CssSelector(".r>a"));
            Assert.True(webElements.Count > 0);
            Thread.Sleep(1000);

        }
        */
    }
}
