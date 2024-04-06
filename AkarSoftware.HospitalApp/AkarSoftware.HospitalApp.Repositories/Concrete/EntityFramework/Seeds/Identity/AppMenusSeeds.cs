using AkarSoftware.HospitalApp.Entities.Concrete.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Seeds.Identity
{
    public class AppMenusSeeds : IEntityTypeConfiguration<AppMenus>
    {
        public void Configure(EntityTypeBuilder<AppMenus> builder)
        {
            builder.HasData(
                new AppMenus
                {
                    Id = 1,
                    RootMenusId = null,
                    MenuName = "Randevu Al",
                    MenuDesctiption = "Randevu Al Linki için kullanılır ",
                    AreaName = "Landing",
                    ControllerName = "Randevu",
                    ActionName = "RandevuAl",
                    ActionParameters = string.Empty,
                    IconName = "randevu",
                    AppModulesId = 1,
                    IsActive = true,
                    CreatedUserId = 0,
                    CreatedUser = "APP",
                    CreatedDate= DateTime.Now,
                    ModifiedUserId = 0,
                    ModifiedUserName = "APP",
                    ModifiedDate = DateTime.Now,
                     
                },
                 new AppMenus
                 {
                     Id = 2,
                     RootMenusId = null,
                     MenuName = "Kurumsal",
                     MenuDesctiption = string.Empty,
                     AreaName = "Landing",
                     ControllerName = "Kurumsal",
                     ActionName = "Index",
                     ActionParameters = string.Empty,
                     IconName = "Kurumsal",
                     AppModulesId = 1,
                     IsActive = true,
                     CreatedUserId = 0,
                     CreatedUser = "APP",
                     CreatedDate = DateTime.Now,
                     ModifiedUserId = 0,
                     ModifiedUserName = "APP",
                     ModifiedDate = DateTime.Now,

                 },
                 new AppMenus
                 {
                     Id = 3,
                     RootMenusId = 2,
                     MenuName = "Hakkımızda",
                     MenuDesctiption = string.Empty,
                     AreaName = "Hakkımızda",
                     ControllerName = "Kurumsal",
                     ActionName = "Index",
                     ActionParameters = string.Empty,
                     IconName = "Kurumsal",
                     AppModulesId = 1,
                     IsActive = true,
                     CreatedUserId = 0,
                     CreatedUser = "APP",
                     CreatedDate = DateTime.Now,
                     ModifiedUserId = 0,
                     ModifiedUserName = "APP",
                     ModifiedDate = DateTime.Now,

                 },
                                  new AppMenus
                                  {
                                      Id = 4,
                                      RootMenusId = 3,
                                      MenuName = "Misyon",
                                      MenuDesctiption = string.Empty,
                                      AreaName = "Misyon",
                                      ControllerName = "Kurumsal",
                                      ActionName = "Index",
                                      ActionParameters = string.Empty,
                                      IconName = "Kurumsal",
                                      AppModulesId = 1,
                                      IsActive = true,
                                      CreatedUserId = 0,
                                      CreatedUser = "APP",
                                      CreatedDate = DateTime.Now,
                                      ModifiedUserId = 0,
                                      ModifiedUserName = "APP",
                                      ModifiedDate = DateTime.Now,

                                  }








                );
        }
    }
}
