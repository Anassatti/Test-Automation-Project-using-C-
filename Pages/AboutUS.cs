using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepInsightsAutomation.Pages
{
    public class AboutUS
    {
        public AboutUS(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver { get; }
        public IWebElement lnkAboutUS => Driver.FindElement(By.XPath("//header/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[2]/a[1]/span[1]/span[1]"));
        public void AboutusClick() => lnkAboutUS.Click();
        public IWebElement AboutusText => Driver.FindElement(By.LinkText("Dream Team)]"));
    }
}
