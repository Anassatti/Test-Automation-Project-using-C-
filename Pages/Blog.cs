using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepInsightsAutomation.Pages
{
    public class Blog
    {
        public Blog(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        private IWebDriver Driver { get; }
        public IWebElement BlogLnk => Driver.FindElement(By.XPath("//header/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[5]/a[1]/span[1]/span[1]"));
        public void BlogClick() => BlogLnk.Click();

        //Verify if we are in the Our services page of not

        public IWebElement BlogTxt => Driver.FindElement(By.LinkText("Building Test Automation Framework uisng Machine Learning)]"));

    }
}
