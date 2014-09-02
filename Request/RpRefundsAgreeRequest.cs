using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.rp.refunds.agree
    /// </summary>
    public class RpRefundsAgreeRequest : ITopRequest<RpRefundsAgreeResponse>
    {
        /// <summary>
        /// 短信验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 需要退款的退款ID以及和其对应的金额列表，其中金额以分为单位，ID与金额以“|”符号分隔，多笔订单以“,”分隔。version 取退款更新时间modified（需转成时间戳格式）
        /// </summary>
        public string RefundInfos { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.rp.refunds.agree";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("code", this.Code);
            parameters.Add("refund_infos", this.RefundInfos);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("refund_infos", this.RefundInfos);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
    }
}
