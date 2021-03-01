using System;
using TechTalk.SpecFlow;

namespace AutotraderDemo.StepDefinition
{
    [Binding]
    public class CarSteps
    {
        [Given(@"I navigate")]
        public void GivenINavigate()
        {
            ScenarioContext.Current.Pending();
        }

        
        [Given(@"I enter username")]
        public void GivenIEnterUsername()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I enter password")]
        public void GivenIEnterPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to login")]
        public void ThenIShouldBeAbleToLogin()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
