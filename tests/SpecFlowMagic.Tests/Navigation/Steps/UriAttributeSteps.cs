using FluentAssertions;
using SpecFlowMagic.Navigation;
using TechTalk.SpecFlow;

namespace SpecFlowMagic.Tests.Navigation.Steps
{
    [Binding]
    public class UriAttributeSteps
    {
        private string _uri;
        private UriAttribute _uriAttribute;

        [Given(@"uri is '(.*)'")]
        public void GivenUriIs(string uri)
        {
            _uri = uri;
        }

        [Given(@"uri (.*) has leading slash")]
        public void GivenUriHasLeadingSlash(string uri)
        {
            // SpecFlow cannot handle uri actually having a leading slash.
            GivenUriIs("/" + uri);
        }

        [When(@"I call new UriAttribute\(uri\)")]
        public void WhenICallNewUriAttributeUri()
        {
            _uriAttribute = new UriAttribute(_uri);
        }

        [Then(@"the UriAttribute object is created")]
        public void ThenTheUriAttributeObjectIsCreated()
        {
            _uriAttribute.Should().NotBeNull();
        }
    }
}