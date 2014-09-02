using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.brandservice.isfan.query
    /// </summary>
    public class BrandserviceIsfanQueryRequest : ITopRequest<BrandserviceIsfanQueryResponse>
    {
        /// <summary>
        /// 站长用户id
        /// </summary>
        public Nullable<long> SiteOwnerId { get; set; }

        /// <summary>
        /// 用户nick
        /// </summary>
        public string UserNick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.brandservice.isfan.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("site_owner_id", this.SiteOwnerId);
            parameters.Add("user_nick", this.UserNick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("site_owner_id", this.SiteOwnerId);
            RequestValidator.ValidateRequired("user_nick", this.UserNick);
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
