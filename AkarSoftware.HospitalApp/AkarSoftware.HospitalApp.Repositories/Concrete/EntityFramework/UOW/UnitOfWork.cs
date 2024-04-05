using AkarSoftware.HospitalApp.Core.Entities.Abstract;
using AkarSoftware.HospitalApp.Core.Repositories.EntityFramework.Abstract;
using AkarSoftware.HospitalApp.Core.Repositories.EntityFramework.Concrete;
using AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework;
using AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.Contexts;

namespace AkarSoftware.HospitalApp.Repositories.Concrete.EntityFramework.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyContexts _context;
        public UnitOfWork(MyContexts context)
        {
            _context = context;
        }
        public UnitOfWork()
        {

        }

        #region Costume Services
        /// <summary>
        /// İlgili alan için costume bir şekilde oluşturulmuş olan repositoryler bu etapta bu yapıdan çekilecektir. 
        /// </summary>

        #endregion

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public IEfGenericRepository<T> GetGenericRepositories<T>() where T : class, IEntity, new()
        {
            var repository = new EfGenericRepository<T>(_context);
            return repository;
        }

        //[Obsolete("Eski kullanım artık property bazında service çağırılması gerekecektir")]
        //public TRepository ReturnRepository<T, TRepository>() where T : BaseEntity, new() where TRepository : IEfGenericRepository<T>, new()
        //{
        //    var repository = (TRepository)Activator.CreateInstance(typeof(TRepository), _context);
        //    return repository;
        //}
    }
}
