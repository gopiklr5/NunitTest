// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.Collections.Generic;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClass
    {

        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver();
        }



        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            driver.Url = "http://www.google.co.in";
            driver.Close();

        }
    }
}
