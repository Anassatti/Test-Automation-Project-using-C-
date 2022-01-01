using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepInsightsAutomation.Pages
{

    public class ContactUS
    {
        public ContactUS(IWebDriver webDriver)
        {
            Driver = webDriver;
        }
        public IWebDriver Driver { get; }
        public IWebElement ContuctusLnk => Driver.FindElement(By.XPath("//header/div[1]/div[1]/div[2]/div[1]/nav[1]/ul[1]/li[6]/a[1]/span[1]/span[1]"));
        public void ContuctusClick() => ContuctusLnk.Click();
        
        //Contuct Us form-Add data
        // Add name
        public IWebElement Namefield => Driver.FindElement(By.XPath("//input[@placeholder='Name*']"));
        public void AddName() => Namefield.SendKeys("Anas");
        // Add Email
        public IWebElement Emailfield => Driver.FindElement(By.XPath("//input[@placeholder='E-mail*']"));
        public void AddEmail() => Emailfield.SendKeys("anasssatti@yahoo.com");
        // Add Subject
        public IWebElement Subjectfield => Driver.FindElement(By.XPath("//input[@placeholder='Subject*']"));
        public void AddSubject() => Subjectfield.SendKeys("A new Contract");
        // Add Message
        public IWebElement Messagefield => Driver.FindElement(By.XPath("//textarea[@placeholder='Message']"));
        public void SendMessage() => Messagefield.SendKeys("Hello, I like your website");

        //Submit the Message
        public IWebElement SubmitButton => Driver.FindElement(By.XPath("//input[@value='Send message']"));
        public void SubmitMessgae() => SubmitButton.Click();

        //Verify if we are in the Our services page of not

        public IWebElement ContactusTxt => Driver.FindElement(By.XPath("//*[@id=wpcf7 - f3083 - p495 - o1]/form/div[3]"));


    }


}
