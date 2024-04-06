using AkarSoftware.HospitalApp.Core.Utilities.Result.Base;
using AkarSoftware.HospitalApp.Core.Utilities.Result.CostumeResults;
using AkarSoftware.HospitalApp.Dtos.Identities.AppMenus;
using AkarSoftware.HospitalApp.Entities.Concrete.Identities;
using AkarSoftware.HospitalApp.Managers.Abstract;
using AkarSoftware.HospitalApp.Managers.Concrete.ConstVerables;
using AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework;
using AutoMapper;
using System.Linq.Expressions;

namespace AkarSoftware.HospitalApp.Managers.Concrete.Managers
{
    public class LandingManager : BaseManager, ILandingService
    {
        public LandingManager(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public async Task<IDataResult<List<AppMenusListDto>>> GetLandingNavigationMenus()
        {
            var repository = _UnitOfWork.GetGenericRepositories<AppMenus>();
            var result =  await repository.GetAllAsync(x => x.AppModules.Id == 1 && x.RootMenusId == null , IncludeProperties: new Expression<Func<AppMenus, object>>[] {c=> c.RootMenus, c=> c.ChildMenus} );
            
            if (result == null || result.Count == 0 )
                return new ErrorDataResult<List<AppMenusListDto>>(Messages.Status.NotFound);
           
            var Dtos = _Mapper.Map<List<AppMenusListDto>>(result);
            return new DataResult<List<AppMenusListDto>>(Dtos, status: Core.Utilities.Result.ComplexTypes.ResultStatus.Success);
        }
    }
}
