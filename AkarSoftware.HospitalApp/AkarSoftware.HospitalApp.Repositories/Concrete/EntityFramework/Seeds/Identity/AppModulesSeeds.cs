using AkarSoftware.HospitalApp.Entities.Concrete.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Seeds.Identity
{
    public class AppModulesSeeds : IEntityTypeConfiguration<AppModules>
    {
        public void Configure(EntityTypeBuilder<AppModules> builder)
        {
            builder.HasData(new AppModules
            {
                Id = 1,
                Name = "Landing",
                Description = "Herkesin Gördüğü Tanıtım Sayfası İçeriklerini içermektedir ",
                IsActive = true,
                CreatedUserId = 0,
                CreatedUser = "APP",
                CreatedDate = DateTime.Now,
                ModifiedUserId = 0,
                ModifiedUserName = "APP",
                ModifiedDate = DateTime.Now,
            },
            new AppModules
            {
                Id = 2,
                Name = "Admin",
                Description = "Bilgi İşlem Direktörlüğü ve Şirket sahiplerinin erişebildiği bir Modül ",
                IsActive = true,
                CreatedUserId = 0,
                CreatedUser = "APP",
                CreatedDate = DateTime.Now,
                ModifiedUserId = 0,
                ModifiedUserName = "APP",
                ModifiedDate = DateTime.Now

            });
        }
    }
}
