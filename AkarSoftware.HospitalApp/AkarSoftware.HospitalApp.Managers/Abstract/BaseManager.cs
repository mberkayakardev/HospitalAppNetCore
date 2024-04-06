using AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework;
using AutoMapper;

namespace AkarSoftware.HospitalApp.Managers.Abstract
{
    public class BaseManager
    {
        protected readonly IMapper _Mapper;
        protected readonly IUnitOfWork _UnitOfWork;
        public BaseManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _Mapper = mapper;
            _UnitOfWork = unitOfWork;
        }
    }
}
