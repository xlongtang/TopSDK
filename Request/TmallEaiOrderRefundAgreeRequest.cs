using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.eai.order.refund.agree
    /// </summary>
    public class TmallEaiOrderRefundAgreeRequest : ITopRequest<TmallEaiOrderRefundAgreeResponse>
    {
        /// <summary>
        /// 短信验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 需要退款的退款ID|其对应的金额|对应版本号列表|退款阶段（onsale\aftersale），其中金额以分为单位，ID与金额以“|”符号分隔，多笔订单以“,”分隔。允许批量操作30笔，最大金额1W。
        /// </summary>
        public string RefundInfos { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.eai.order.refund.agree";
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
