using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.xhotel.city.get
    /// </summary>
    public class XhotelCityGetRequest : ITopRequest<XhotelCityGetResponse>
    {
        /// <summary>
        /// 分页读取的城市个数，最小值为1，最大值为200
        /// </summary>
        public Nullable<long> Count { get; set; }

        /// <summary>
        /// 分页读取的开始下标,从0开始
        /// </summary>
        public Nullable<long> Start { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.xhotel.city.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("count", this.Count);
            parameters.Add("start", this.Start);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("count", this.Count);
            RequestValidator.ValidateRequired("start", this.Start);
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
