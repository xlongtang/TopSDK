using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weitao.feed.isrelation
    /// </summary>
    public class WeitaoFeedIsrelationRequest : ITopRequest<WeitaoFeedIsrelationResponse>
    {
        /// <summary>
        /// 要查询的粉丝的淘宝昵称
        /// </summary>
        public string FansNick { get; set; }

        /// <summary>
        /// 要查询的公共账号的淘宝昵称
        /// </summary>
        public string SellerNick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weitao.feed.isrelation";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fans_nick", this.FansNick);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fans_nick", this.FansNick);
            RequestValidator.ValidateRequired("seller_nick", this.SellerNick);
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
