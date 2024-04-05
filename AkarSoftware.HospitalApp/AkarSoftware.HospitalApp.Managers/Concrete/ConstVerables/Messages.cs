namespace AkarSoftware.HospitalApp.Managers.Concrete.ConstVerables
{
    public static class Messages
    {
        public static class CRUD
        {
            public const string Created = "Kayıt Olusturuldu.";
            public const string Updated = "Kayıt Güncellendi.";
            public const string Deleted = "Kayıt Silindi";
            public const string SoftDeleted = "Kayıt Silindi";
        }

        public static class Status
        {
            public const string Success = "İşlem Başarılı.";
            public const string NotFound = "Kayıt Bulunamadı.";
            public const string NotCreated = "Kayıt Oluşturulamadı.";
            public const string MediaUploadError = "Media yüklemesi gerçekleştirilirken bir hata meydana geldi : ";
        }

    }
}
