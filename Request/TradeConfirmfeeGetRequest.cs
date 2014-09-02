using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.confirmfee.get
    /// </summary>
    public class TradeConfirmfeeGetRequest : ITopRequest<TradeConfirmfeeGetResponse>
    {
        /// <summary>
        /// 是否是子订单。可选值:IS_FATHER(父订单),IS_CHILD(子订单)
        /// </summary>
        public string IsDetail { get; set; }

        /// <summary>
        /// 交易编号，或子订单编号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.confirmfee.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_detail", this.IsDetail);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("is_detail", this.IsDetail);
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
