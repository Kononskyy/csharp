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

namespace csharp.test.classwork.lesson12
{
    class Client_IntakeForm
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
                IWebElement query = driver.FindElement(By.Name("q"));
                query.SendKeys("Cheese");
                query.Submit(); //send table via POST method to server
                Thread.Sleep(10000); //dangerous hack
                ReadOnlyCollection<IWebElement> webElents;
                webElents = driver.FindElements(By.CssSelector(".r>a"));
                Assert.True(webElents.Count > 0);
                //Thread.Sleep(1000);
            }
        }
    }
}
