using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fuwu.sale.link.gen
    /// </summary>
    public class FuwuSaleLinkGenRequest : ITopRequest<FuwuSaleLinkGenResponse>
    {
        /// <summary>
        /// 用户需要营销的目标人群中的用户nick
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 从服务商后台，营销链接功能中生成的参数串直接复制使用。不要修改，否则抛错。
        /// </summary>
        public string ParamStr { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fuwu.sale.link.gen";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("param_str", this.ParamStr);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("param_str", this.ParamStr);
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
