using MarsQA1.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MarsQA1.MarsQASpecflow
{
    [Binding]
    public  class LoginStepDefs
    {
        readonly IWebDriver driver = new ChromeDriver();        

        [Given(@"I login to the portal")]
        public void GivenILoginToThePortal()
        {
            //navigate to the Url
            driver.Navigate().GoToUrl("http://localhost:5000");
        }

        [When(@"I add the credentials")]
        public void WhenIAddTheCredentials()
        {
            //go to login pageobject LoginPage 
            var loginPage = new LoginPage(driver);
            loginPage.Login();
        }

        [Then(@"I verify that I am into the Dashboard of the portal")]
        public void ThenIVerifyThatIAmIntoTheDashboardOfThePortal()
        {
            //verify that you are in the correct profile page
            Thread.Sleep(3000);
            var isnamepresent = driver.FindElement(By.XPath("//span[text() = 'rashmi']"));
            Assert.IsTrue(isnamepresent.Displayed, "the value for name is not present");
            driver.Close();
        }   
        
        public void CloseDriver()
        {
            //closes all the browser windows opened by the webdriver
            driver.Quit();
        }
    }
}
