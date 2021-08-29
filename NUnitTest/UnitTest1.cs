using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace NUnitTest
{
    public class Tests
    {

        IWebDriver webDriver;


        [OneTimeSetUp]
        public void StartChrome()
        {
            webDriver = new ChromeDriver(@"D:\Software");
        }

        [Test]
        public void Test1()
        {
            webDriver.Url = "https://localhost:44301/";
            Thread.Sleep(1000);
            //IWebElement txtSearch = webDriver.FindElement(By.ClassName("gLFyf"));
            //txtSearch.SendKeys("Hello Good Mrng");
            IWebElement linkContact = webDriver.FindElement(By.LinkText("Contact"));
            linkContact.Click();

            Thread.Sleep(1000);
            IWebElement linkAbout = webDriver.FindElement(By.LinkText("About"));
            linkAbout.Click();

            Assert.Pass();
        }

        [OneTimeTearDown]
        public void CloseTest()
        {
            //webDriver.Close();
        }
    }
}