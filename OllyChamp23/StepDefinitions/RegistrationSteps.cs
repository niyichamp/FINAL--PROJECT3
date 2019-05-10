using System;
using TechTalk.SpecFlow;

namespace OllyChamp23.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Registered link")]
        public void WhenIClickOnRegisteredLink()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Registration page should be displayed")]
        public void ThenTheRegistrationPageShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
