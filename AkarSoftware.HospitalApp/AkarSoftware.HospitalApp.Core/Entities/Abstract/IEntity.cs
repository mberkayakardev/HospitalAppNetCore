namespace AkarSoftware.HospitalApp.Core.Entities.Abstract
{
    /// <summary>
    /// Bu interface proje içerisinde yer alan sınıflardan Entity görevini üstelenecek olan sınıfların ayrıştırılması için kullanılan bir imzadır. 
    /// </summary>
    public interface IEntity 
    {
        public int Id { get; set; } // Primary Key 
        public bool IsActive { get; set; } // Safe Delete 

        
        public DateTime? CreatedDate { get; set; } 
        public int? CreatedUserId { get; set; }
        public string? CreatedUser { get; set; }
        

        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedUserId { get; set; }
        public string? ModifiedUserName { get; set; }

    }
}
