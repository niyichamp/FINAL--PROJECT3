using System;
using OllyChamp23.PageObjects;
using OllyChamp23.Utilities;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace OllyChamp23.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {

        LoginPage.
        [Given(@"I am a registered user of Giftrete site")]
        public void GivenIAmARegisteredUserOfGiftreteSite;
        
     Hooks1.Driver.Navigate().("http://www.qa1.giftrt.com");

          


        

           
        }

    [When(@"I click on login")]
    p Public void WhenIClickLoginPage();
        {
        Hooks1.Driver.FindElememt(By.XPath("//span[text()= 'Login']"(.Click();
        }
        
        [Given(@"I enter my username")]
        public void GivenIEnterMyUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter my password")]
        public void GivenIEnterMyPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click sign in")]
        public void WhenIClickSignIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the giftrete homepage should be opened")]
        public void ThenTheGiftreteHomepageShouldBeOpened()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
