using AkarSoftware.HospitalApp.Core.Extentions.FluentValidation.ComplexTypes;
using AkarSoftware.HospitalApp.Core.Utilities.Result.ComplexTypes;

namespace AkarSoftware.HospitalApp.Core.Utilities.Result.CostumeResults
{
    public class SuccessResult : AkarSoftware.HospitalApp.Core.Utilities.Result.Base.Result 
    {

        public SuccessResult() : base (ResultStatus.Success)
        {
            
        }

        public SuccessResult(string Message) : base(ResultStatus.Success, Message)
        {

        }

    }
}
