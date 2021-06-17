namespace Localization.Client.Options
{
    public class LocalizeOption
    {
        public string DefaultLanguage { get; set; }
        public string[] ResourceSet { get; protected set; }
        public ConnectionType Connection { get; set; }
        public LocalizeOption ConfigureResourceSet(params string[] resourceSet)
        {
            ResourceSet = resourceSet;
            return this;
        }
    }
}
