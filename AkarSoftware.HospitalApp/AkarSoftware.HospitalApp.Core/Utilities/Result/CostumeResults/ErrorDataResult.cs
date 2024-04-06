using AkarSoftware.HospitalApp.Core.Extentions.FluentValidation.ComplexTypes;
using AkarSoftware.HospitalApp.Core.Utilities.Result.Base;
using AkarSoftware.HospitalApp.Core.Utilities.Result.ComplexTypes;

namespace AkarSoftware.HospitalApp.Core.Utilities.Result.CostumeResults
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(string Messages) : base(default, status: ResultStatus.Error, Messages)
        {
        }

        public ErrorDataResult(List<ErrorModels> errorModels) : base(default, status: ResultStatus.Error, string.Empty)
        {
        }

        public ErrorDataResult(string Messages, IEnumerable<ErrorModels> Errors) : base(default, ResultStatus.Error, Errors)
        {
        }
    }
}
