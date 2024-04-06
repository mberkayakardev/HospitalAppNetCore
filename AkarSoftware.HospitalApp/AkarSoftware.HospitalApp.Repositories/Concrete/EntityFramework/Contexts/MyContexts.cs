using AkarSoftware.HospitalApp.Entities.Concrete.Identities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Emit;

namespace AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Contexts
{
    public class MyContexts : DbContext
    {

        public MyContexts(DbContextOptions<MyContexts> options) : base (options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

     

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        #region DbSets 

        #region Identities 
        public DbSet<AppMenus> AppMenus { get; set; }
        public DbSet<Genders> Genders { get; set; }
        public DbSet<Genders> AppModules { get; set; }
        public DbSet<Genders> AppRoles { get; set; }
        public DbSet<Genders> AppRolesMenus { get; set; }
        public DbSet<Genders> AppUser { get; set; }
        public DbSet<Genders> AppUserRoles { get; set; }
        #endregion











        #endregion
    }
}
