using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.laiwang.user.list.get
    /// </summary>
    public class AlibabaLaiwangUserListGetRequest : ITopRequest<AlibabaLaiwangUserListGetResponse>
    {
        /// <summary>
        /// 第一个拉取的OPENID，不填默认从头开始拉取
        /// </summary>
        public string NextOpenid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alibaba.laiwang.user.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("next_openid", this.NextOpenid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
