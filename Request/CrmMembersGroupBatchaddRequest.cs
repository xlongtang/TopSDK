using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.members.group.batchadd
    /// </summary>
    public class CrmMembersGroupBatchaddRequest : ITopRequest<CrmMembersGroupBatchaddResponse>
    {
        /// <summary>
        /// 会员的id（一次最多传入10个）
        /// </summary>
        public string BuyerIds { get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        public string GroupIds { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.members.group.batchadd";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_ids", this.BuyerIds);
            parameters.Add("group_ids", this.GroupIds);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("buyer_ids", this.BuyerIds);
            RequestValidator.ValidateMaxListSize("buyer_ids", this.BuyerIds, 10);
            RequestValidator.ValidateRequired("group_ids", this.GroupIds);
            RequestValidator.ValidateMaxListSize("group_ids", this.GroupIds, 10);
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
