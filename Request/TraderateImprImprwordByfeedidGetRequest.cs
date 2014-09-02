using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderate.impr.imprword.byfeedid.get
    /// </summary>
    public class TraderateImprImprwordByfeedidGetRequest : ITopRequest<TraderateImprImprwordByfeedidGetResponse>
    {
        /// <summary>
        /// 交易订单id号（如果包含子订单，请使用子订单id号）
        /// </summary>
        public Nullable<long> ChildTradeId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderate.impr.imprword.byfeedid.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("child_trade_id", this.ChildTradeId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("child_trade_id", this.ChildTradeId);
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
