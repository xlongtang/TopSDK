using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qianniu.number.put
    /// </summary>
    public class QianniuNumberPutRequest : ITopRequest<QianniuNumberPutResponse>
    {
        /// <summary>
        /// 考虑到稳定性，建议一次卖家最多为200个。 标准json格式的数组构成的字符串。每个元素为{user_id:****,field:"****",value:"****"}分别是用户的userid，数据的名称，以及数据的值。
        /// </summary>
        public string Data { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.qianniu.number.put";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("data", this.Data);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("data", this.Data);
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
