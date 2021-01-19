using MarsQA1.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.MarsQASpecflow
{
    [Binding]
    public class Descstepdefs
    {
        readonly IWebDriver driver = new ChromeDriver();
                       
        
        [Given(@"I login to the portal and add the credentials")]
        public void GivenILoginToThePortalAndAddTheCredentials()
        {
            //navigate to the Url
            driver.Navigate().GoToUrl("http://localhost:5000");

            //go to login pageobject LoginPage to add credentials
            var loginPage = new LoginPage(driver);
            loginPage.Login();
        }

        [When(@"I click the description edit button and add in the description")]
        public void WhenIClickTheDescriptionEditButtonAndAddInTheDescription()
        {
            //verify that the login is successfull and add description on the profile tab
            var profilePage = new ProfPage(driver);
            profilePage.Profile1();
        }

        [Then(@"the description is saved and displayed")]
        public void ThenTheDescriptionIsSavedAndDisplayed()
        {
            //verify that the 'saved' message is displayed
            Thread.Sleep(3000);
            var isdescpresent = driver.FindElement(By.XPath("//span[contains(text(),'I am a tester')]"));
            Assert.IsTrue(isdescpresent.Displayed, "the value for name is not present");
            driver.Close();
            //var profilePage = new ProfPage(driver);
            //var descdetail = profilePage.verifyDescDetails();
            //Assert.That(descdetail, Does.Contain("I am a tester"));
        }

        public void CloseDriver()
        {
            //closes all the browser windows opened by the webdriver
            driver.Quit();
        }
    }
}
