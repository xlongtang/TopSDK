using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alibaba.xiami.api.contract.sellerlist.get
    /// </summary>
    public class AlibabaXiamiApiContractSellerlistGetRequest : ITopRequest<AlibabaXiamiApiContractSellerlistGetResponse>
    {
        /// <summary>
        /// 每页数量
        /// </summary>
        public Nullable<long> Limit { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string TimeEnd { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string TimeStart { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alibaba.xiami.api.contract.sellerlist.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("limit", this.Limit);
            parameters.Add("page", this.Page);
            parameters.Add("time_end", this.TimeEnd);
            parameters.Add("time_start", this.TimeStart);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("limit", this.Limit);
            RequestValidator.ValidateRequired("page", this.Page);
            RequestValidator.ValidateRequired("time_end", this.TimeEnd);
            RequestValidator.ValidateRequired("time_start", this.TimeStart);
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
