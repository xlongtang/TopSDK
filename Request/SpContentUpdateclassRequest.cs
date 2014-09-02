using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sp.content.updateclass
    /// </summary>
    public class SpContentUpdateclassRequest : ITopRequest<SpContentUpdateclassResponse>
    {
        /// <summary>
        /// 新分类名称
        /// </summary>
        public string Newname { get; set; }

        /// <summary>
        /// 旧分类名称
        /// </summary>
        public string Oldname { get; set; }

        /// <summary>
        /// 站长Key<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string SiteKey { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sp.content.updateclass";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("newname", this.Newname);
            parameters.Add("oldname", this.Oldname);
            parameters.Add("site_key", this.SiteKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("newname", this.Newname);
            RequestValidator.ValidateRequired("oldname", this.Oldname);
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
