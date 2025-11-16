using TechTalk.SpecFlow;
using NUnit.Framework;
using Hooks;

namespace StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given("I open Google page")]
        public void GivenIOpenGooglePage()
        {
            DriverHooks.driver.Navigate().GoToUrl("https://google.com");
        }

        [Then("I should see Google title")]
        public void ThenIShouldSeeGoogleTitle()
        {
            Assert.That(DriverHooks.driver.Title.Contains("Google"), Is.True);
        }
    }
}
