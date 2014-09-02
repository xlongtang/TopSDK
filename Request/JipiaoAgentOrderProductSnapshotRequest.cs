using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jipiao.agent.order.product.snapshot
    /// </summary>
    public class JipiaoAgentOrderProductSnapshotRequest : ITopRequest<JipiaoAgentOrderProductSnapshotResponse>
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jipiao.agent.order.product.snapshot";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("order_id", this.OrderId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
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
