using Localization.Client.Repository;

namespace Localization.Client
{
    public class LocalizationResolver
    {
        private string resourceSet;
        private string language;
        private IResourceRepository resourceRepository;

        public LocalizationResolver(string resourceSet, string lang, IResourceRepository resourceRepository)
        {
            this.resourceSet = resourceSet;
            language = lang;
            this.resourceRepository = resourceRepository;
        }
        public string Get(string code)
        {
            var entity = resourceRepository.Find(p => p.ResourceKey == code
                                                   && p.ResourceSet == resourceSet
                                                   && p.Language == language);
            if (entity.Result == null)
            {
                return code;
            }
            return entity.Result.LocalizeText;
        }
    }
}
