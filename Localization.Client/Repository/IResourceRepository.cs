using Localization.Core.Entities.Resource;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Localization.Client.Repository
{
    public interface IResourceRepository
    {
        Task<Resource> Find(Expression<Func<Resource, bool>> filter);
    }
}
