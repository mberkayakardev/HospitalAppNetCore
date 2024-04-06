using AkarSoftware.HospitalApp.Core.Entities.Abstract;

namespace AkarSoftware.HospitalApp.Entities.Concrete.Identities
{
    public class AppMenus : BaseEntity
    {
        public int? RootMenusId { get; set; }
        public string MenuName { get; set; }
        public string? MenuDesctiption { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string? ActionParameters { get; set; }
        public string? IconName { get; set; }    

        #region Navigation Propert
        public int? AppModulesId { get; set; }
        public AppModules AppModules { get; set; }
        public List<AppRolesMenus> AppRolesMenus { get; set; }
        public List<AppMenus> ChildMenus { get; set; } // Child Menuler 
        public AppMenus RootMenus { get; set; } // Root Menüler 
        #endregion
    }
}
