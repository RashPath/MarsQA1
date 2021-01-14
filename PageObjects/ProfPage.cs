using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQA1.PageObjects
{ 
    public class ProfPage : ProfPageBase
    {
        readonly IWebDriver driver;

        public ProfPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Profile1()
        {
            //click on 'profile' tab
            //Thread.Sleep(2000);
            //var gotoProfile = driver.FindElement(By.XPath("//a[@class='item' and @href='/Account/Profile']"));
            //gotoProfile.Click();

            //click on "Description edit" button and add description
            Thread.Sleep(5000);
            var desc = driver.FindElement(By.XPath("//i[@class='outline write icon']/ancestor::span[@class='button']"));
            desc.Click();

            //enter your description
            Thread.Sleep(5000);
            var desc1 = driver.FindElement(By.XPath("//textarea[@name='value']"));
            desc1.SendKeys("I am a tester");

          //  Assert.AreEqual("I am a tester", desc1.Text);

            //save the description
            driver.FindElement(By.XPath("//button[@class='ui teal button' and @type='button']")).Click();
        }
    }

}


