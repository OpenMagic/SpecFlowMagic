using TechTalk.SpecFlow;

namespace SpecFlowMagic.Page
{
    [Binding]
    public class PageBindings
    {
        [When(@"I enter data")]
        public void WhenIEnterData(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I choose (.+)")]
        public void WhenIChooseElement(string elementId)
        {
            ScenarioContext.Current.Pending();
        }
    }
}