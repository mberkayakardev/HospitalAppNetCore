using AkarSoftware.HospitalApp.Entities.Concrete.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Seeds.Identity
{
    public class GenderSeeds : IEntityTypeConfiguration<Genders>
    {
        public void Configure(EntityTypeBuilder<Genders> builder)
        {
            builder.HasData(
                new Genders
                {
                    Id = 1,
                    Name = "Erkek",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    CreatedUser = "APP",
                    CreatedUserId = 0,
                    ModifiedDate = DateTime.Now,
                    ModifiedUserId = 0,
                    ModifiedUserName = "APP"
                },
                new Genders
                {
                    Id = 2,
                    Name = "Kadın",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    CreatedUser = "APP",
                    CreatedUserId = 0,
                    ModifiedDate = DateTime.Now,
                    ModifiedUserId = 0,
                    ModifiedUserName = "APP"
                },
                new Genders
                {
                    Id = 3,
                    Name = "Belirtmek İstemiyor",
                    IsActive = true,
                    CreatedDate = DateTime.Now,
                    CreatedUser = "APP",
                    CreatedUserId = 0,
                    ModifiedDate = DateTime.Now,
                    ModifiedUserId = 0,
                    ModifiedUserName = "APP"
                });

        }
    }
}
