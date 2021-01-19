using MarsQA1.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace MarsQA1.MarsQASpecflow
{
    [Binding]
    public class Detailsteps
    {
        readonly IWebDriver driver = new ChromeDriver();
        
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
            //verify that the 'saved' options are displayed - assert one of the displays

            //explicit wait
            var wait = new WebDriverWait(driver, TimeSpan.FromMinutes(1));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));

            var optionsave = driver.FindElement(By.XPath("//span/select/option[2][contains(text(), 'Part Time')]"));
            Assert.IsTrue(optionsave.Displayed, "the value for message is not present");

            //Thread.Sleep(3000);
            //var optionsave2 = driver.FindElement(By.XPath("//span[contains(text(), 'As needed')]"));
            //Assert.IsTrue(optionsave2.Displayed, "the value for message is not present");

            //Thread.Sleep(3000);
            //var optionsave3 = driver.FindElement(By.XPath("//span[contains(text(), 'More than $1000 per month')]"));
            //Assert.IsTrue(optionsave3.Displayed, "the value for message is not present");

            

            driver.Close();
        }

        public void CloseDriver()
        {
            //closes all the browser windows opened by the webdriver
            driver.Quit();
        }


    }
}