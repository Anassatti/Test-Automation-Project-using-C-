using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepInsightsAutomation.Pages
{
    public class Homepage
    {
        public Homepage(IWebDriver webDriver)
        {
            Driver = webDriver;
        }

        private IWebDriver Driver { get; }
        public IWebElement lnkSearch => Driver.FindElement(By.XPath("//div[@class='qodef-vertical-align-containers']//span[@class='qodef-icon-font-elegant icon_search ']"));
      
        public IWebElement  txtAdd =>Driver.FindElement(By.TagName("input"));


        public IWebElement lnkSearchbutton => Driver.FindElement(By.XPath("//button[@type='submit']//span[contains(@class,'qodef-icon-font-elegant icon_search')]"));
        //Return to HomePage
        public IWebElement lnkReturnHomePage => Driver.FindElement(By.LinkText("Home"));
       
        //Operations code
        public void SearchClick()=> lnkSearch.Click();  
        public void AddData() => txtAdd.SendKeys("Test Automation");
        public void SearchButton() => lnkSearchbutton.Click();
        public void HomePage() => lnkReturnHomePage.Click();
        //Verify if we are in the homepage page of not
        public IWebElement OurWorkText => Driver.FindElement(By.LinkText("Our Work')]"));
    }
}
