using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trip.jipiao.agent.order.hk
    /// </summary>
    public class TripJipiaoAgentOrderHkRequest : ITopRequest<TripJipiaoAgentOrderHkResponse>
    {
        /// <summary>
        /// 国内机票订单id
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// hk（占座）时需要的信息信息列表，元素结构：乘机人姓名;pnr (以分号进行分隔).
        /// </summary>
        public string PnrInfo { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trip.jipiao.agent.order.hk";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("order_id", this.OrderId);
            parameters.Add("pnr_info", this.PnrInfo);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("pnr_info", this.PnrInfo);
            RequestValidator.ValidateMaxListSize("pnr_info", this.PnrInfo, 9);
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
