using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ju.citygroup.get
    /// </summary>
    public class JuCitygroupGetRequest : ITopRequest<JuCitygroupGetResponse>
    {
        /// <summary>
        /// 需要获取生活服务商品的城市名称（中文）
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 代表需要返回的商品对象字段。可选值：ItemData商品结构体中所有字段均可返回；多个字段用“,”分隔。如果fields为空，或者不传该参数，就默认获得所有的字段
        /// </summary>
        public string Fields { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ju.citygroup.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("city", this.City);
            parameters.Add("fields", this.Fields);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("city", this.City);
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
