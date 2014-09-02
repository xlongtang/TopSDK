using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.group.filter
    /// </summary>
    public class HanoiGroupFilterRequest : ITopRequest<HanoiGroupFilterResponse>
    {
        /// <summary>
        /// 认证信息
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 买家的nick
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 分组的id
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// 卖家nick
        /// </summary>
        public string SellerNick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.group.filter";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("group_id", this.GroupId);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("buyer_nick", this.BuyerNick);
            RequestValidator.ValidateRequired("group_id", this.GroupId);
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
