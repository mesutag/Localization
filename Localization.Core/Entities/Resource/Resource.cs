namespace Localization.Core.Entities.Resource
{
    public class Resource
    {
        public int Id { get; protected set; }
        public string ResourceKey { get; protected set; }
        public string Language { get; protected set; }
        public string ResourceSet { get; protected set; }
        public string LocalizeText { get; protected set; }
        public Resource(string resourceKey, string language, string resourceSet, string localizeText)
        {
            ResourceKey = resourceKey;
            Language = language;
            ResourceSet = resourceSet;
            LocalizeText = localizeText;
        }
        public Resource(int id, string resourceKey, string language, string resourceSet, string localizeText)
        {
            Id = id;
            ResourceKey = resourceKey;
            Language = language;
            ResourceSet = resourceSet;
            LocalizeText = localizeText;
        }
    }
}
