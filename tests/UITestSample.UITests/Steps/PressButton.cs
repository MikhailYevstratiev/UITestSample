using System;

using TechTalk.SpecFlow;
using UITestSample.UITests.Pages;

namespace UITestSample.UITests.Steps
{
    [Binding]
    public class PressButton
    {
        [Given("I am on the Buttons Page")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator()
        {
            // TODO: implement arrange (recondition) logic
            // For storing and retrieving scenario-specific data, 
            // the instance fields of the class or the
            //     ScenarioContext.Current
            // collection can be used.
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            new ButtonsPage()
                .AssertOnPage();
        }

        [When("I press 'Click me!' button (.*) times")]
        public void WhenIPressAdd(int n)
        {
            // TODO: implement act (action) logic

            var page = new ButtonsPage();

            for (int i = 0; i < n; i++)
            {
                page.TapColorButton();
            }
        }

        [When("I press 'Go to List page' button")]
        public void WhenIPressAdd()
        {
            // TODO: implement act (action) logic
            new ButtonsPage()
                .GoToListPage();
        }

        [Then("I am navigated to the List page")]
        public void ThenTheResultShouldBe()
        {
            // TODO: implement assert (verification) logic

            new ListPage()
                .AssertOnPage();
        }
    }
}
