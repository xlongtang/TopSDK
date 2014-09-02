using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.dd.auction.rule.delete
    /// </summary>
    public class DdAuctionRuleDeleteRequest : ITopRequest<DdAuctionRuleDeleteResponse>
    {
        /// <summary>
        /// 规则ID
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 是否是外卖
        /// </summary>
        public Nullable<bool> IsTakeout { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        public string StoreId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.dd.auction.rule.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("is_takeout", this.IsTakeout);
            parameters.Add("store_id", this.StoreId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
            RequestValidator.ValidateRequired("is_takeout", this.IsTakeout);
            RequestValidator.ValidateRequired("store_id", this.StoreId);
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
