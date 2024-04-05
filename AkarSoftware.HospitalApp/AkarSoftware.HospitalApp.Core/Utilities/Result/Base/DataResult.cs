
using AkarSoftware.HospitalApp.Core.Extentions.FluentValidation.ComplexTypes;
using AkarSoftware.HospitalApp.Core.Utilities.Result.ComplexTypes;

namespace AkarSoftware.HospitalApp.Core.Utilities.Result.Base
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, ResultStatus status, string Messages) : base(status, Messages)
        {
            this.Data = data;
        }
        public DataResult(T data, ResultStatus status) : base(status)
        {
            this.Data = data;

        }
        public DataResult(T data, ResultStatus status, IEnumerable<ErrorModels> Errors) : base(status, "", Errors)
        {
            this.Data = data;

        }
        public T Data { get; }
    }
}
