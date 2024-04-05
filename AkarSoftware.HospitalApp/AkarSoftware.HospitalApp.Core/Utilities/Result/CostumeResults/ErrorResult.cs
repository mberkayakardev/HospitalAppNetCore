using AkarSoftware.HospitalApp.Core.Extentions.FluentValidation.ComplexTypes;

namespace AkarSoftware.HospitalApp.Core.Utilities.Result.CostumeResults
{
    public class ErrorResult : AkarSoftware.HospitalApp.Core.Utilities.Result.Base.Result
    {
        public ErrorResult(string Message) : base (status: ComplexTypes.ResultStatus.Error, Message) 
        {
            
        }

        public ErrorResult(string Message, List<ErrorModels> errors) : base(status: ComplexTypes.ResultStatus.Error, Message, errors)
        {

        }
    }
}
