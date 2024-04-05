using AkarSoftware.HospitalApp.Core.Utilities.Result.Base;
using AkarSoftware.HospitalApp.Managers.Abstract;
using AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework;
using AutoMapper;
using Microsoft.AspNetCore.Http;

namespace AkarSoftware.HospitalApp.Managers.Concrete.Managers.Media
{
    public class LocalMediaManager : BaseManager, IMediaServices
    {
        public LocalMediaManager(IMapper mapper, IUnitOfWork unitOfWork) : base(mapper, unitOfWork)
        {
        }

        public Task<IResult> AddMediaAsync(IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> DeleteMediaAsync(string MediaId)
        {
            throw new NotImplementedException();
        }
    }
}
