using AkarSoftware.HospitalApp.Core.Entities.Abstract;

namespace AkarSoftware.HospitalApp.Entities.Concrete.Identities
{
    public class AppRoles : BaseEntity
    {
        public string RoleName { get; set; }
        public string? Description {  get; set; }

        #region Navigation Property
        public List<AppUserRoles> AppUserRoles { get; set; }
        public List<AppRolesMenus> AppRolesMenus { get; set; }
        #endregion
    }
}
