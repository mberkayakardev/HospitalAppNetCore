using AkarSoftware.HospitalApp.Core.Entities.Abstract;

namespace AkarSoftware.HospitalApp.Entities.Concrete.Identities
{
    public class Genders : BaseEntity
    {
        public string Name { get; set; }

        #region Navigation Property
        public List<AppUser> AppUsers { get; set; }

        #endregion
    }
}
