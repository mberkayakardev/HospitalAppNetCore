using AkarSoftware.HospitalApp.Core.Dtos.Abstract;

namespace AkarSoftware.HospitalApp.Dtos.Identities.AppMenus
{
    public class AppMenusListDto : BaseUpdateDto
    {

        public int? RootMenusId { get; set; }
        public string MenuName { get; set; }
        public string? MenuDesctiption { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string? ActionParameters { get; set; }
        public string? IconName { get; set; }
        public bool IsActive { get; set; }
        public List<AppMenusListDto> ChildMenus { get; set; } // Child Menuler 
        public AppMenusListDto RootMenus { get; set; } // Root Menüler 

    }
}
