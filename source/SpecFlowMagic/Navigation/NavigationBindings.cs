using TechTalk.SpecFlow;

namespace SpecFlowMagic.Navigation
{
    [Binding]
    public class NavigationBindings
    {
        [Given(@"I navigated to the (.+) page")]
        public void GivenINavigatedToPage(string pageName)
        {
            ScenarioContext.Current.Pending();
        }
    }
}