using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQA1.PageObjects
{
    public class AddDetails
    {
        readonly IWebDriver driver;

        public AddDetails(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void Details()
        {
            //enter the availability
            Thread.Sleep(5000);
            var avail = driver.FindElement(By.XPath("//i[@class='large calendar icon']//parent::span//following-sibling::div//i[@class='right floated outline small write icon']"));
            avail.Click();

            Thread.Sleep(5000);
            var availtype = driver.FindElement(By.XPath("//select[@name='availabiltyType']"));
            availtype.Click();

            Thread.Sleep(5000);
            var timer = driver.FindElement(By.XPath("//option[contains(text(),'Part Time')]"));
            timer.Click();

            //enter the hours
            Thread.Sleep(5000);
            var availhours = driver.FindElement(By.XPath("//i[@class='large clock outline check icon']//parent::span//following-sibling::div//i[@class='right floated outline small write icon']"));
            availhours.Click();

            Thread.Sleep(5000);
            var hourtype = driver.FindElement(By.XPath("//select[@name='availabiltyHour']"));
            hourtype.Click();

            Thread.Sleep(5000);
            var htime = driver.FindElement(By.XPath("//option[contains(text(),'As needed')]"));
            htime.Click();

            //enter the earn target
            var earnings = driver.FindElement(By.XPath(" //i[@class='large dollar icon']//parent::span//following-sibling::div//i[@class='right floated outline small write icon']"));
            earnings.Click();

            Thread.Sleep(5000);
            var earntype = driver.FindElement(By.XPath("//select[@name='availabiltyTarget']"));
            earntype.Click();

            Thread.Sleep(5000);
            var dollars = driver.FindElement(By.XPath("//option[contains(text(),'More than $1000 per month')]"));
            dollars.Click();
        }
    }
}
