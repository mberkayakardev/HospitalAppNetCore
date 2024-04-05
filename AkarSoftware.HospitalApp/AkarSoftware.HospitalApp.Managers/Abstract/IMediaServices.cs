using AkarSoftware.HospitalApp.Core.Utilities.Result.Base;
using Microsoft.AspNetCore.Http;

namespace AkarSoftware.HospitalApp.Managers.Abstract
{
    public interface IMediaServices
    {
        Task<IResult> AddMediaAsync(IFormFile file);
        Task<IResult> DeleteMediaAsync(string MediaId);

    }
}
