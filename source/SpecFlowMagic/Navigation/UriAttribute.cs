using System;

namespace SpecFlowMagic.Navigation
{
    public class UriAttribute : Attribute
    {
        private string _uri;

        public UriAttribute(string uri)
        {
            _uri = uri;
        }
    }
}