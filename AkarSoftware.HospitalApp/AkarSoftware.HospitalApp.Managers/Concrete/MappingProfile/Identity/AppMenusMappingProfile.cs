using AkarSoftware.HospitalApp.Dtos.Identities.AppMenus;
using AkarSoftware.HospitalApp.Entities.Concrete.Identities;
using AutoMapper;

namespace AkarSoftware.HospitalApp.Managers.Concrete.MappingProfile.Identity
{
    public class AppMenusMappingProfile: Profile
    {
        public AppMenusMappingProfile()
        {
            CreateMap<AppMenusListDto, AppMenus>().ReverseMap();
              
        }
    }
}
