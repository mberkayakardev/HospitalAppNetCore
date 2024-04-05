using AkarSoftware.HospitalApp.Core.Entities.Abstract;

namespace AkarSoftware.HospitalApp.Entities.Concrete.Identities
{
    public class AppUserRoles : BaseEntity
    {
        public int UserId { get; set; }
        public AppUser AppUser { get; set; }   
        public int RoleId { get; set; } 
        public AppRoles Roles { get; set; }
    }
}
