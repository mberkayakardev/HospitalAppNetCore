using AkarSoftware.HospitalApp.Entities.Concrete.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Configurations.Identity
{
    public class AppModulesConfiguration : IEntityTypeConfiguration<AppModules>
    {
        public void Configure(EntityTypeBuilder<AppModules> builder)
        {
            builder.Property(x=> x.Name).HasMaxLength(256);
           
        }
    }
}
