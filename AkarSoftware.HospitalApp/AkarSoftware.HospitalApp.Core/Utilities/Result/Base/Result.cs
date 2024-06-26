﻿using AkarSoftware.HospitalApp.Core.Extentions.FluentValidation.ComplexTypes;
using AkarSoftware.HospitalApp.Core.Utilities.Result.ComplexTypes;

namespace AkarSoftware.HospitalApp.Core.Utilities.Result.Base
{
    public class Result : IResult
    {
        public string Messages { get; }
        public ResultStatus Status { get; }
        public IEnumerable<ErrorModels> ValidationErrors { get; }
        public Result(ResultStatus status, string StatusMessages, IEnumerable<ErrorModels> Errors) : this(status, StatusMessages)
        {
            ValidationErrors = Errors;
        }

        public Result(ResultStatus status, string StatusMessages) : this(status)
        {
            this.Messages = StatusMessages;
        }

        public Result(ResultStatus status)
        {
            this.Status = status;
        }

        public Result(ResultStatus status, IEnumerable<ErrorModels> Errors) : this(status, string.Empty, Errors)
        {

        }
    }
}
