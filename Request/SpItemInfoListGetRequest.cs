using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sp.item.info.list.get
    /// </summary>
    public class SpItemInfoListGetRequest : ITopRequest<SpItemInfoListGetResponse>
    {
        /// <summary>
        /// 商品ID,可批量查询, 多个商品ID中间用逗号分隔, 最多可查20个id, ID之间不能有空格
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 每个站点的唯一Key(加密的site id)
        /// </summary>
        public string SiteKey { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sp.item.info.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("site_key", this.SiteKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
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
