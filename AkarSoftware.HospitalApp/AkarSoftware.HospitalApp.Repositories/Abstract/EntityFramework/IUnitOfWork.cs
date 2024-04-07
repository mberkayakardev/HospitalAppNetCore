using AkarSoftware.HospitalApp.Core.Entities.Abstract;
using AkarSoftware.HospitalApp.Core.Repositories.EntityFramework.Abstract;

namespace AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework
{
    /// <summary>
    /// Entityler için Transaction yönetimi ve Repository erişimi buradan gerçekleşecektir. 
    /// </summary>
    public interface IUnitOfWork
    {
        #region CostumeRepositories
        IAppMenuRepository AppMenuRepository { get; }
        #endregion

        /// <summary>
        /// Generic olarak Entity Bazında Repositoryler çağırmak isterseniz kullanacağınız Methodlar
        /// </summary>
        IEfGenericRepository<T> GetGenericRepositories<T>() where T : class, IEntity, new();

        /// <summary>
        ///  Transaction işleminin asenkronik bir şekilde işlemesi için kullanılır
        /// </summary>
        Task SaveChangesAsync();

        /// <summary>
        ///  Transaction işleminin senkron bir şekilde işlemesi için kullanılır
        /// </summary>
        void SaveChanges();

        // public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity, new() where TRepository : IEfGenericRepository<T>, new();

    }
}
