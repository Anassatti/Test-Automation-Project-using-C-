using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepInsightsAutomation.Pages
{
   public class Careers
    {
        public Careers(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver { get; }

        public IWebElement CareerLnk => Driver.FindElement(By.XPath("//header/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[4]/a[1]/span[1]/span[1]"));
        public void CareersClick() => CareerLnk.Click();

        //Verify if we are in the careers page of not

        public IWebElement CopywriterTxt => Driver.FindElement(By.LinkText("Copywriter)]"));
    }
}
