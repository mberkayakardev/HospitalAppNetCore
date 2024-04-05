using AkarSoftware.HospitalApp.Core.Extentions.FluentValidation.ComplexTypes;
using AkarSoftware.HospitalApp.Core.Utilities.Result.ComplexTypes;

namespace AkarSoftware.HospitalApp.Core.Utilities.Result.Base
{
    public interface IResult
    {
        public ResultStatus Status { get; }
        public string Messages { get; }
        public IEnumerable<ErrorModels> ValidationErrors { get; }
    }
}
