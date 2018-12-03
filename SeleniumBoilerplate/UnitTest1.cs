using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Selenium関連パッケージ
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;


namespace SeleniumBoilerplate
{
    [TestClass]
    public class BrowserTest
    {
        [TestMethod]
        public void TestChromeDriver()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
            }
        }

        [TestMethod]
        public void TestFirefoxDriver()
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
            }
        }

        [TestMethod]
        public void TestEdgeDriver()
        {
            using (IWebDriver driver = new EdgeDriver())
            {
            }
        }

        [TestMethod]
        public void TestPhantomJSDriver()
        {
            using (IWebDriver driver = new PhantomJSDriver())
            {
            }
        }
    }
}
