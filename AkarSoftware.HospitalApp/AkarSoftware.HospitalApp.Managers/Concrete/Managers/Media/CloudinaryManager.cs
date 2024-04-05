using AkarSoftware.HospitalApp.Core.Extentions.FluentValidation.ComplexTypes;
using AkarSoftware.HospitalApp.Core.Utilities.Result.Base;
using AkarSoftware.HospitalApp.Core.Utilities.Result.CostumeResults;
using AkarSoftware.HospitalApp.Managers.Abstract;
using AkarSoftware.HospitalApp.Managers.Concrete.Options.Cloudinary;
using AkarSoftware.HospitalApp.Repositories.Abstract.EntityFramework;
using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace AkarSoftware.HospitalApp.Managers.Concrete.Managers.Media
{
    public class CloudinaryManager : BaseManager, IMediaServices
    {
        private readonly CloudianryOptions _Cloudinaryverables;
        private readonly Cloudinary _cloudinary;
        public CloudinaryManager(IUnitOfWork unitOfWork, IMapper mapper, IOptions<CloudianryOptions> cloudinaryverables) : base( mapper, unitOfWork)
        {
            _Cloudinaryverables = cloudinaryverables.Value;
            var account = new Account(_Cloudinaryverables.CloudName, _Cloudinaryverables.CloudinaryApiKey, _Cloudinaryverables.CloudinaryApiSecrets);
            _cloudinary = new Cloudinary(account);
        }

        public async Task<IResult> AddMediaAsync(IFormFile file)
        {
            var uploadresult = new ImageUploadResult();

            if (file.Length > 0)
            {
                using var stream = file.OpenReadStream();
                var uploadparams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream),
                    Transformation = new Transformation().Height(500).Width(500).Crop("fill").Gravity("face")
                };

                uploadresult = await _cloudinary.UploadAsync(uploadparams);


                if (uploadresult.Error != null)
                {
                    return new SuccessResult("İşlem başarılı ");
                }

                return  new ErrorResult("İlgili İşlem başarı ile gerçekleştirilemedi ", new List<Core.Extentions.FluentValidation.ComplexTypes.ErrorModels>() { new ErrorModels { ErrorMessage = uploadresult.Error.Message, PropertyName = string.Empty  } });

            }
            else
            {
                return new ErrorResult("İlgili İşlem başarı ile gerçekleştirilemedi ", new List<Core.Extentions.FluentValidation.ComplexTypes.ErrorModels>() { new ErrorModels { ErrorMessage = uploadresult.Error.Message, PropertyName = "herhangi bir dosya seçimi gerçekleşmedi "} });

            }

        }

        public async Task<IResult> DeleteMediaAsync(string MediaId)
        {
            var deleteParams = new DeletionParams(MediaId);
            var result = await _cloudinary.DestroyAsync(deleteParams);
            if (result.Error != null)
            {
                return new SuccessResult("İşlem başarılı ");
            }

            return new ErrorResult("İlgili İşlem başarı ile gerçekleştirilemedi ", new List<Core.Extentions.FluentValidation.ComplexTypes.ErrorModels>() { new ErrorModels { ErrorMessage = result.Error.Message, PropertyName = string.Empty } });

        }
    }
}
