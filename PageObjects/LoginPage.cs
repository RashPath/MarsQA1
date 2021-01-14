using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MarsQA1.PageObjects
{
    public class LoginPage
    {
        readonly IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public void Login()
        {
            //navigate to the Url
            //driver.Navigate().GoToUrl("http://localhost:5000");

            //explicit wait
            var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            //click the sign in button
            var signIn = driver.FindElement(By.XPath("//a[contains(text(),'Sign In')]"));
            signIn.Click();

            //enter your username and password

            driver.FindElement(By.XPath("//input[@placeholder = 'Email address']")).SendKeys("rash.tripathy@gmail.com");

            driver.FindElement(By.XPath("//input[@placeholder = 'Password']")).SendKeys("123412");

            //click the Login button

            driver.FindElement(By.XPath("//button[@class='fluid ui teal button']")).Click();

            //verify that you are in the correct profile page
            //var isnamepresent = driver.FindElement(By.XPath("//span[text() = 'rashmi']"));
            //Assert.IsTrue(isnamepresent.Displayed, "the value for name is not present");

        }
    }
}
