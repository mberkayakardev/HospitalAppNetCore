using AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework;
using AutoMapper;

namespace AkarSoftware.HospitalApp.Managers.Abstract
{
    public class BaseManager
    {
        private readonly IMapper _Mapper;
        private readonly IUnitOfWork _UnitOfWork;
        public BaseManager(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _Mapper = mapper;
            _UnitOfWork = unitOfWork;
        }
    }
}
