using Localization.Client.Options;
using Localization.Client.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Localization.Client.ModuleConfiguration
{
    public static class InitModule
    {
        public static void AddLocalizationConfiguration(this IServiceCollection services, Action<LocalizeOption> option)
        {
            services.Configure(option);
            services.AddContextConfiguration();
            services.AddRepositoryConfiguration();

            services.AddScoped<ILocalization, Localization>();
        }
        private static void AddContextConfiguration(this IServiceCollection services)
        {
            //LocalizeOption domainContext = services.BuildServiceProvider().GetRequiredService<IOptions<LocalizeOption>>().Value;
            //services.AddDbContext<LocalizationContext>(o =>
            //{
            //    o.UseNpgsql(domainContext.Connection.ConnectionString);
            //});
        }

        private static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IResourceRepository, ResourceRepository>();
        }
    }

}
