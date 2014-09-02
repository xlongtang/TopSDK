using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.brandservice.fanscount.query
    /// </summary>
    public class BrandserviceFanscountQueryRequest : ITopRequest<BrandserviceFanscountQueryResponse>
    {
        /// <summary>
        /// 站长用户id
        /// </summary>
        public Nullable<long> SiteOwnerId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.brandservice.fanscount.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("site_owner_id", this.SiteOwnerId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("site_owner_id", this.SiteOwnerId);
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
