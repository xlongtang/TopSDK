using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.item.consignment.delete
    /// </summary>
    public class WlbItemConsignmentDeleteRequest : ITopRequest<WlbItemConsignmentDeleteResponse>
    {
        /// <summary>
        /// 代销商前台宝贝ID
        /// </summary>
        public Nullable<long> IcItemId { get; set; }

        /// <summary>
        /// 货主的物流宝商品ID
        /// </summary>
        public Nullable<long> OwnerItemId { get; set; }

        /// <summary>
        /// 授权关系id
        /// </summary>
        public Nullable<long> RuleId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.item.consignment.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ic_item_id", this.IcItemId);
            parameters.Add("owner_item_id", this.OwnerItemId);
            parameters.Add("rule_id", this.RuleId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ic_item_id", this.IcItemId);
            RequestValidator.ValidateRequired("owner_item_id", this.OwnerItemId);
            RequestValidator.ValidateRequired("rule_id", this.RuleId);
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
