using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.tradeorder.get
    /// </summary>
    public class WlbTradeorderGetRequest : ITopRequest<WlbTradeorderGetResponse>
    {
        /// <summary>
        /// 子交易号
        /// </summary>
        public string SubTradeId { get; set; }

        /// <summary>
        /// 指定交易类型的交易号
        /// </summary>
        public string TradeId { get; set; }

        /// <summary>
        /// 交易类型:  TAOBAO--淘宝交易  OTHER_TRADE--其它交易
        /// </summary>
        public string TradeType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.tradeorder.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("sub_trade_id", this.SubTradeId);
            parameters.Add("trade_id", this.TradeId);
            parameters.Add("trade_type", this.TradeType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("trade_id", this.TradeId);
            RequestValidator.ValidateRequired("trade_type", this.TradeType);
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
