using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Localization.Core.Context;
using Localization.Core.Entities.Resource;

namespace Localization.Client.Repository
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly LocalizationContext context;
        public ResourceRepository(LocalizationContext context)
        {
            this.context = context;
        }
        public async Task<Resource> Find(Expression<Func<Resource, bool>> filter)
        {
            return await context.Set<Resource>().FirstOrDefaultAsync(filter);
        }
    }
}
