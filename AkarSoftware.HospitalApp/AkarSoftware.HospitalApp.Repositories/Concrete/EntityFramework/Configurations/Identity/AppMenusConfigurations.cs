using AkarSoftware.HospitalApp.Entities.Concrete.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Configurations.Identity
{
    public class AppMenusConfigurations : IEntityTypeConfiguration<AppMenus>
    {
        public void Configure(EntityTypeBuilder<AppMenus> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=> x.RootMenus).WithMany(x=> x.ChildMenus).HasForeignKey(x=>x.RootMenusId).IsRequired(false);
        }
    }
}
