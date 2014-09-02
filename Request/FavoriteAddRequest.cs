using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.favorite.add
    /// </summary>
    public class FavoriteAddRequest : ITopRequest<FavoriteAddResponse>
    {
        /// <summary>
        /// ITEM表示宝贝，SHOP表示店铺，只能传入这两者之一
        /// </summary>
        public string CollectType { get; set; }

        /// <summary>
        /// 如果收藏的是商品，就传num_iid，如果是店铺，就传入sid
        /// </summary>
        public Nullable<long> ItemNumid { get; set; }

        /// <summary>
        /// 该收藏是否公开
        /// </summary>
        public Nullable<bool> Shared { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.favorite.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("collect_type", this.CollectType);
            parameters.Add("item_numid", this.ItemNumid);
            parameters.Add("shared", this.Shared);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("collect_type", this.CollectType);
            RequestValidator.ValidateRequired("item_numid", this.ItemNumid);
            RequestValidator.ValidateMinValue("item_numid", this.ItemNumid, 1);
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
