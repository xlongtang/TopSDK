using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.laiwang.pp.menu.create
    /// </summary>
    public class AlibabaLaiwangPpMenuCreateRequest : ITopRequest<AlibabaLaiwangPpMenuCreateResponse>
    {
        /// <summary>
        /// 菜单的定义,将定义转换成对应的json格式传入。
        /// </summary>
        public string Menudef { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alibaba.laiwang.pp.menu.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("menudef", this.Menudef);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("menudef", this.Menudef);
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
