using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.itemrecommend.items.get
    /// </summary>
    public class ItemrecommendItemsGetRequest : ITopRequest<ItemrecommendItemsGetResponse>
    {
        /// <summary>
        /// 请求返回宝贝的个数，建议取20个
        /// </summary>
        public Nullable<long> Count { get; set; }

        /// <summary>
        /// 额外的参数信息
        /// </summary>
        public string Ext { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 查询类型标识符，可传入1-3，1：同类商品推荐，2：异类商品推荐， 3：同店商品推荐。其他值当非法值处理
        /// </summary>
        public Nullable<long> RecommendType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.itemrecommend.items.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("count", this.Count);
            parameters.Add("ext", this.Ext);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("recommend_type", this.RecommendType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("count", this.Count);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("recommend_type", this.RecommendType);
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
