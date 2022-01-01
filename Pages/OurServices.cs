using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepInsightsAutomation.Pages
{
    public class OurServices
    {
        public OurServices(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver { get; }

        public IWebElement OurServiceLnk => Driver.FindElement(By.XPath("//header/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[3]/a[1]/span[1]/span[1]"));
        public void OurServiceClick() => OurServiceLnk.Click();

        //Verify if we are in the Our services page of not

        public IWebElement OurServicTxt => Driver.FindElement(By.LinkText("Our Services)]"));


    }
}
