using MarsQA1.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA1.MarsQASpecflow
{
    [Binding]
    public class Detailsteps
    {
        IWebDriver driver = new ChromeDriver();
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Given(@"I signin to the portal")]
        public void GivenISigninToThePortal()
        {
            //navigate to the Url
            driver.Navigate().GoToUrl("http://localhost:5000");

            //go to login pageobject LoginPage to add credentials
            var loginPage = new LoginPage(driver);
            loginPage.Login();
        }

        [When(@"I click on the dropdowns")]
        public void WhenIClickOnTheDropdowns()
        {
            //add further details under Profile tab
            var addDetails = new AddDetails(driver);
            addDetails.Details();
        }

        [Then(@"The options are saved and are displayed on the page")]
        public void ThenTheOptionsAreSavedAndAreDisplayedOnThePage()
        {
            //verify that the 'saved' message is displayed
            var optionsave = driver.FindElement(By.XPath("//div[text() = 'Availability updated']"));
            Assert.IsTrue(optionsave.Displayed, "the value for message is not present");
            driver.Close();
        }

        public void CloseDriver()
        {
            //closes all the browser windows opened by the webdriver
            driver.Quit();
        }


    }
}