using System.Collections.Generic;
using Microsoft.Extensions.Options;
using Localization.Client.Options;
using Localization.Client.Repository;

namespace Localization.Client
{
    public class Localization : ILocalization
    {
        private IResourceRepository resourceRepository;
        private Dictionary<string, LocalizationResolver> resources;
        private LocalizeOption localizeOption;
        public Localization(IResourceRepository resourceRepository, IOptions<LocalizeOption> localizeOption)
        {
            this.localizeOption = localizeOption.Value;
            this.resourceRepository = resourceRepository;
            resources = new Dictionary<string, LocalizationResolver>();
            InitResources();
        }

        public LocalizationResolver this[string resourceSet]
        {
            get => resources[resourceSet];
        }

        public ILocalization SetLanguage(string lang)
        {
            localizeOption.DefaultLanguage = lang;
            InitResources();
            return this;
        }
        private void InitResources()
        {
            foreach (var resourceSet in localizeOption.ResourceSet)
            {
                resources[resourceSet] = new LocalizationResolver(resourceSet, localizeOption.DefaultLanguage, resourceRepository);
            }
        }

    }


}
