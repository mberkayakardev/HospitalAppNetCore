using AkarSoftware.HospitalApp.Core.Entities.Abstract;

namespace AkarSoftware.HospitalApp.Entities.Concrete.Identities
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public bool TwoFactorAuth { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public string EmailAdress { get; set; }
        public bool EmailAdressConfirmed { get; set; }
        public int GenderId { get; set; }
        public Genders Genders { get; set; }
        public string? ProfilePhoto { get; set; }
        public string UserMailAdress { get; set; }
        public DateTime? BornDate { get; set; }

        #region Navigation PRoperty

        public List<AppUserRoles> AppUserRoles { get; set; }
        #endregion
    }
}
