using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sp.shop.extra.info.get
    /// </summary>
    public class SpShopExtraInfoGetRequest : ITopRequest<SpShopExtraInfoGetResponse>
    {
        /// <summary>
        /// 店铺编号。shop+sid.taobao.com即店铺地址，如shop123456.taobao.com
        /// </summary>
        public Nullable<long> ShopId { get; set; }

        /// <summary>
        /// 每个站点的唯一Key(加密的site id)
        /// </summary>
        public string SiteKey { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sp.shop.extra.info.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("shop_id", this.ShopId);
            parameters.Add("site_key", this.SiteKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shop_id", this.ShopId);
            RequestValidator.ValidateRequired("site_key", this.SiteKey);
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
