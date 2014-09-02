using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.waimai.refuse
    /// </summary>
    public class TradeWaimaiRefuseRequest : ITopRequest<TradeWaimaiRefuseResponse>
    {
        /// <summary>
        /// 买家付款未发货订单号
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 拒单理由
        /// </summary>
        public string Reason { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.waimai.refuse";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("order_id", this.OrderId);
            parameters.Add("reason", this.Reason);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("reason", this.Reason);
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
