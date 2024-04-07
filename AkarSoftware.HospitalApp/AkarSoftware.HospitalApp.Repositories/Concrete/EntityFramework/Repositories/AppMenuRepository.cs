using AkarSoftware.HospitalApp.Core.Repositories.EntityFramework.Concrete;
using AkarSoftware.HospitalApp.Entities.Concrete.Identities;
using AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework;
using AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Repositories
{
    public class AppMenuRepository : EfGenericRepository<AppMenus>, IAppMenuRepository
    {
        private readonly MyContexts contexts;
        public AppMenuRepository(MyContexts dbContext) : base(dbContext)
        {
            contexts = dbContext;
        }

        public async Task<List<AppMenus>> GetAllAppMenusForLandingWithRecursive()
        {
            var GroupedMenus = await contexts.AppMenus.GroupBy(x => x.RootMenusId).Select(g => new { RootMenusId = g.Key, Counts = g.Count() }).ToListAsync();
            var maxdepth = GroupedMenus.Count;

            var MenusReuslt = contexts.AppMenus.AsQueryable().Include(x=> x.ChildMenus);
            
            for (int i = 0; i < maxdepth; i++)
            {
                MenusReuslt = MenusReuslt.ThenInclude(x => x.ChildMenus);
            }

            return await MenusReuslt.ToListAsync();

              
     
        }
    }
}
