using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ts.property.get
    /// </summary>
    public class TsPropertyGetRequest : ITopRequest<TsPropertyGetResponse>
    {
        /// <summary>
        /// 服务收费项code<br /> 支持最大长度为：64<br /> 支持的最大列表长度为：64
        /// </summary>
        public string ServiceItemCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ts.property.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("service_item_code", this.ServiceItemCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("service_item_code", this.ServiceItemCode);
            RequestValidator.ValidateMaxLength("service_item_code", this.ServiceItemCode, 64);
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
