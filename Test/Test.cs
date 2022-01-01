using DeepInsightsAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepInsightsAutomation.Test
{
    class Test
    {
        IWebDriver webDriver = new ChromeDriver(@"C:\Users\anass\Desktop\Files\Seleium\Driver\LastVersion");
        [SetUp]
        public void Setup()
        {
           
            webDriver.Navigate().GoToUrl("https://deepinsights99.com/");
            webDriver.Manage().Window.Maximize();
      
        }
        //Testcase 1--->Homepage page
        [Test]
     
        public void Homepage()
        {

            Homepage home = new Homepage(webDriver);
            home.SearchClick();
            home.AddData();
            home.SearchButton();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            home.HomePage();
        }
        // Testcase 2--->About us page
        [Test]
        public void Test2_AboutUS()
        {
            AboutUS aboutus = new AboutUS(webDriver);
            aboutus.AboutusClick();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        [Test]
        public void Test3_OurServices()
        {
            OurServices services = new OurServices(webDriver);
            services.OurServiceClick();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        [Test]
        public void Test3_Careers()
        {
            Careers career = new Careers(webDriver);
            career.CareersClick();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        [Test]
        public void Test4_Blog()
        {
            Blog blogpage = new Blog(webDriver);
            blogpage.BlogClick();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }
        [Test]
        public void Test5_ContactUs()
        {
            ContactUS contact = new ContactUS(webDriver);
            contact.ContuctusClick();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            contact.AddName();
            contact.AddEmail();
            contact.AddSubject();
            contact.SendMessage();
            contact.SubmitMessgae();
        }

        public void TextVerificationsAssert()
        {
            Homepage home = new Homepage(webDriver);
            Assert.That(home.OurWorkText, Is.True);
            AboutUS aboutus = new AboutUS(webDriver);
            Assert.That(aboutus.AboutusText, Is.True);
            OurServices services = new OurServices(webDriver);
            Assert.That(services.OurServicTxt, Is.True);
            Careers career = new Careers(webDriver);
            Assert.That(career.CopywriterTxt, Is.True);
            Blog blogpage = new Blog(webDriver);
            Assert.That(blogpage.BlogTxt, Is.True);
            ContactUS contact= new ContactUS(webDriver);
            Assert.AreEqual(contact.ContactusTxt,"Thank you for your message. It has been sent.");
        }
       // [TearDown]
        //public void TearDown() => webDriver.Quit();

    }
}
