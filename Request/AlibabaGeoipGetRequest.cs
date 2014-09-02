using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.geoip.get
    /// </summary>
    public class AlibabaGeoipGetRequest : ITopRequest<AlibabaGeoipGetResponse>
    {
        /// <summary>
        /// 要查询的IP地址,与language一起使用，与iplist二选一使用，提供单个IP查询
        /// </summary>
        public string Ip { get; set; }

        /// <summary>
        /// 返回结果的文字语言，cn中文；en英文
        /// </summary>
        public string Language { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alibaba.geoip.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ip", this.Ip);
            parameters.Add("language", this.Language);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ip", this.Ip);
            RequestValidator.ValidateRequired("language", this.Language);
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
