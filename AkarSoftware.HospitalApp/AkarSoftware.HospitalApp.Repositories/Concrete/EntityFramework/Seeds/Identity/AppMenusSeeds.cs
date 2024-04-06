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
                    MenuDesctiption = "Randevu Al",
                    AreaName = "Randevu Al",
                    ControllerName = "Randevu Al",
                    ActionName = "Randevu Al",
                    ActionParameters = string.Empty,
                    IconName = "Randevu Al",
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
                     AreaName = "Kurumsal",
                     ControllerName = "Kurumsal",
                     ActionName = "Kurumsal",
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
                     ControllerName = "Hakkımızda",
                     ActionName = "Hakkımızda",
                     ActionParameters = string.Empty,
                     IconName = "Hakkımızda",
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
                     ControllerName = "Misyon",
                     ActionName = "Misyon",
                     ActionParameters = string.Empty,
                     IconName = "Misyon",
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
                     Id = 5,
                     RootMenusId = 3,
                     MenuName = "Vizyon",
                     MenuDesctiption = string.Empty,
                     AreaName = "Vizyon",
                     ControllerName = "Vizyon",
                     ActionName = "Vizyon",
                     ActionParameters = string.Empty,
                     IconName = "Vizyon",
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
                     Id = 6,
                     RootMenusId = 3,
                     MenuName = "Kariyer",
                     MenuDesctiption = string.Empty,
                     AreaName = "Kariyer",
                     ControllerName = "Kariyer",
                     ActionName = "Kariyer",
                     ActionParameters = string.Empty,
                     IconName = "Kariyer",
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
                    Id = 7,
                    RootMenusId = null,
                    MenuName = "Sonuçlar",
                    MenuDesctiption = string.Empty,
                    AreaName = "Sonuçlar",
                    ControllerName = "Sonuçlar",
                    ActionName = "Sonuçlar",
                    ActionParameters = string.Empty,
                    IconName = "Sonuçlar",
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
                    Id = 8,
                    RootMenusId = 7,
                    MenuName = "Reçete",
                    MenuDesctiption = string.Empty,
                    AreaName = "Reçete",
                    ControllerName = "Reçete",
                    ActionName = "Reçete",
                    ActionParameters = string.Empty,
                    IconName = "Reçete",
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
                    Id = 9,
                    RootMenusId = 7,
                    MenuName = "Tahlil",
                    MenuDesctiption = string.Empty,
                    AreaName = "Tahlil ",
                    ControllerName = "Tahlil",
                    ActionName = "Tahlil",
                    ActionParameters = string.Empty,
                    IconName = "Tahlil",
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
                    Id = 10,
                    RootMenusId = null,
                    MenuName = "Doktorlar",
                    MenuDesctiption = string.Empty,
                    AreaName = "Doktorlar",
                    ControllerName = "Doktorlar",
                    ActionName = "Doktorlar",
                    ActionParameters = string.Empty,
                    IconName = "Doktorlar",
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
