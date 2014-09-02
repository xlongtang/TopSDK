using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sp.content.getcount
    /// </summary>
    public class SpContentGetcountRequest : ITopRequest<SpContentGetcountResponse>
    {
        /// <summary>
        /// JSON格式的查询条件：  type(Integer，选填) ：内容类型，包括三种： 1 -- 宝贝，2 -- 图片，3 -- 心得；0或者不填则获取所有类型的内容；     className(String，选填)：内容的自定义分类名称；     tags(String，选填)：内容的自定义标签名称，多个标签以逗号“,”分割。如果设置了多个标签，则他们是或的关系；     title(String，选填): 内容标题，此条件为模糊搜索， 慎用，可能比较慢；     comments (String，选填)：内容的推荐理由，此条件为模糊搜索，慎用，可能会比较慢
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// 站长Key<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string SiteKey { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sp.content.getcount";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("query", this.Query);
            parameters.Add("site_key", this.SiteKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("query", this.Query);
            RequestValidator.ValidateRequired("site_key", this.SiteKey);
            RequestValidator.ValidateMaxLength("site_key", this.SiteKey, 32);
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
