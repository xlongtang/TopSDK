using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.waimai.get
    /// </summary>
    public class TradeWaimaiGetRequest : ITopRequest<TradeWaimaiGetResponse>
    {
        /// <summary>
        /// true-查询仅按商家维度  false-查询按商家下所属店铺维度
        /// </summary>
        public Nullable<bool> IsAll { get; set; }

        /// <summary>
        /// 返回记录数，超过20按20条返回数据<br /> 支持最大值为：20<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> MaxSize { get; set; }

        /// <summary>
        /// 外卖分店ID
        /// </summary>
        public Nullable<long> StoreId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.waimai.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_all", this.IsAll);
            parameters.Add("max_size", this.MaxSize);
            parameters.Add("store_id", this.StoreId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("is_all", this.IsAll);
            RequestValidator.ValidateRequired("max_size", this.MaxSize);
            RequestValidator.ValidateMaxValue("max_size", this.MaxSize, 20);
            RequestValidator.ValidateMinValue("max_size", this.MaxSize, 1);
            RequestValidator.ValidateRequired("store_id", this.StoreId);
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
