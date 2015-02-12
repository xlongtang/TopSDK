using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.receivetime.delay
    /// </summary>
    public class TradeReceivetimeDelayRequest : ITopRequest<TradeReceivetimeDelayResponse>
    {
        /// <summary>
        /// 延长收货的天数，可选值为：3, 5, 7, 10。
        /// </summary>
        public Nullable<long> Days { get; set; }

        /// <summary>
        /// 主订单号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.receivetime.delay";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("days", this.Days);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("days", this.Days);
            RequestValidator.ValidateMaxValue("days", this.Days, 10);
            RequestValidator.ValidateMinValue("days", this.Days, 3);
            RequestValidator.ValidateRequired("tid", this.Tid);
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
