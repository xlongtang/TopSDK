using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.ordersku.update
    /// </summary>
    public class TradeOrderskuUpdateRequest : ITopRequest<TradeOrderskuUpdateResponse>
    {
        /// <summary>
        /// 子订单编号（对于单笔订单的交易可以传交易编号）。
        /// </summary>
        public Nullable<long> Oid { get; set; }

        /// <summary>
        /// 销售属性编号，可以通过taobao.item.skus.get获取订单对应的商品的所有销售属性。
        /// </summary>
        public Nullable<long> SkuId { get; set; }

        /// <summary>
        /// 销售属性组合串，格式：p1:v1;p2:v2，如：1627207:28329;20509:28314。可以通过taobao.item.skus.get获取订单对应的商品的所有销售属性。
        /// </summary>
        public string SkuProps { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.ordersku.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("oid", this.Oid);
            parameters.Add("sku_id", this.SkuId);
            parameters.Add("sku_props", this.SkuProps);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("oid", this.Oid);
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
