using AkarSoftware.HospitalApp.Core.Entities.Abstract;

namespace AkarSoftware.HospitalApp.Entities.Concrete.Identities
{
    public class AppRolesMenus : BaseEntity
    {
        public int AppRoleId { get; set; }
        public AppRoles AppRoles { get; set; }
        public int AppMenusId { get; set; }
        public AppMenus AppMenus { get; set; }

    }
}
