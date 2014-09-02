using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.refund.get
    /// </summary>
    public class FenxiaoRefundGetRequest : ITopRequest<FenxiaoRefundGetResponse>
    {
        /// <summary>
        /// 是否查询下游买家的退款信息
        /// </summary>
        public Nullable<bool> QuerySellerRefund { get; set; }

        /// <summary>
        /// 要查询的退款子单的id
        /// </summary>
        public Nullable<long> SubOrderId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.refund.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query_seller_refund", this.QuerySellerRefund);
            parameters.Add("sub_order_id", this.SubOrderId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sub_order_id", this.SubOrderId);
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
