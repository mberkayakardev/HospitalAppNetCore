using AkarSoftware.HospitalApp.Core.Entities.Abstract;

namespace AkarSoftware.HospitalApp.Entities.Concrete.Identities
{
    public class AppModules : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        #region Navigation Properties

        public List<AppMenus> AppMenus { get; set; }
        #endregion
    }
}
