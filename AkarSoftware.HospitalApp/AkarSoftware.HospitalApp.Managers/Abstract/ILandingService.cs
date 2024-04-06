using AkarSoftware.HospitalApp.Core.Utilities.Result.Base;
using AkarSoftware.HospitalApp.Dtos.Identities.AppMenus;

namespace AkarSoftware.HospitalApp.Managers.Abstract
{
    public interface ILandingService
    {
        public Task<IDataResult<List<AppMenusListDto>>> GetLandingNavigationMenus();
    }
}
