using AkarSoftware.HospitalApp.Core.Repositories.EntityFramework.Abstract;
using AkarSoftware.HospitalApp.Entities.Concrete.Identities;

namespace AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework
{
    public interface IAppMenuRepository : IEfGenericRepository<AppMenus>
    {
        public Task<List<AppMenus>> GetAllAppMenusForLandingWithRecursive();
    }
}
