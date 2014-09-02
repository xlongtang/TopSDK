using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ump.detail.update
    /// </summary>
    public class UmpDetailUpdateRequest : ITopRequest<UmpDetailUpdateResponse>
    {
        /// <summary>
        /// 活动详情内容，可以通过ump sdk中的MarketingTool来生成这个内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 活动详情id
        /// </summary>
        public Nullable<long> DetailId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ump.detail.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("content", this.Content);
            parameters.Add("detail_id", this.DetailId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", this.Content);
            RequestValidator.ValidateRequired("detail_id", this.DetailId);
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
