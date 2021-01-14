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
    public class Languagesteps
    {
        IWebDriver driver;

        [BeforeScenario]

        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }


        [Given(@"I signin to the portal by entering the login details")]
        public void GivenISigninToThePortalByEnteringTheLoginDetails()
        {
            //navigate to the Url
            driver.Navigate().GoToUrl("http://localhost:5000");

            //go to login pageobject LoginPage to add credentials
            var loginPage = new LoginPage(driver);
            loginPage.Login();
        }

        [When(@"I click on the languages tab and add in various options")]
        public void WhenIClickOnTheLanguagesTabAndAddInVariousOptions()
        {
            //add various language options under Profile tab
            var addLang = new AddLanguage(driver);
            addLang.Language();
        }

        [Then(@"My entries are saved and are displayed on the page")]
        public void ThenMyEntriesAreSavedAndAreDisplayedOnThePage()
        {
            //verify that the 'saved' message is displayed
            var Langsave = driver.FindElement(By.XPath("//td[text() = 'English']"));
            Assert.IsTrue(Langsave.Displayed, "the value for message is not present");

        }

        [AfterScenario]
        public void CloseDriver()
        {
            //closes all the browser windows opened by the webdriver
            driver.Quit();
        }

    }
}
