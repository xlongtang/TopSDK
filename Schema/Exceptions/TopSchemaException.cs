using System;
using System.Collections.Generic;
using System.Text;
using Top.Schema.Enums;

namespace Top.Schema.Exceptions
{
    [Serializable]
    public class TopSchemaException : Exception
    {
        public string ErrorCode { get; set; }
        public string ErrorMsg { get; set; }
        public string FieldId { get; set; }

        public TopSchemaException(string message)
            : base(message)
        {
            this.ErrorCode = TopSchemaErrorCodeEnumHelper.ToErrorCode(TopSchemaErrorCodeEnum.ERROR_CODE_40000);
            this.ErrorMsg = message;
        }

        public TopSchemaException(string message, Exception cause)
            : base(message, cause)
        {
            this.ErrorCode = TopSchemaErrorCodeEnumHelper.ToErrorCode(TopSchemaErrorCodeEnum.ERROR_CODE_40000);
            this.ErrorMsg = message;
        }

        public TopSchemaException(string errorCode, string errorMsg)
            : base(errorMsg)
        {
            this.ErrorCode = errorCode;
            this.ErrorMsg = errorMsg;
        }

        public TopSchemaException(TopSchemaErrorCodeEnum codeEnum,  string fieldId)
            : base(TopSchemaErrorCodeEnumHelper.ToMessage(codeEnum))
        {
            string msg = TopSchemaErrorCodeEnumHelper.ToMessage(codeEnum);
            if (!string.IsNullOrEmpty(fieldId))
            {
                msg += "At the filed which id is " + fieldId;
            }
            this.ErrorCode = TopSchemaErrorCodeEnumHelper.ToErrorCode(codeEnum);
            this.ErrorMsg = msg;
            this.FieldId = fieldId;
        }
    }
}
