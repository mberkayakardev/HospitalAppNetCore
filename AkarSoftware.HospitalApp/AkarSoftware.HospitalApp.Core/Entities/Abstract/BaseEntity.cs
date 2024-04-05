
namespace AkarSoftware.HospitalApp.Core.Entities.Abstract
{

    /// <summary>
    /// Bu base class proje içerisinde yer alan sınıflardan Entity görevini üstelenecek olan sınıfların ayrıştırılması için kullanılan bir sınıftır.
    /// Başlangıç konfigürasyonu yada ortak methodlar gibi bazı öğeler içerisinde verilebilir. 
    /// </summary>
    public abstract class BaseEntity : IEntity
    {
        public int Id { get ; set ; }
        public bool IsActive { get ; set ; }
        public DateTime? CreatedDate { get ; set ; }
        public int? CreatedUserId { get ; set ; }
        public string? CreatedUser { get ; set ; }
        public DateTime? ModifiedDate { get ; set ; }
        public int? ModifiedUserId { get ; set ; }
        public string? ModifiedUserName { get ; set ; }
    }
}
