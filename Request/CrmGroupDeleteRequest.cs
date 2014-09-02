using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.group.delete
    /// </summary>
    public class CrmGroupDeleteRequest : ITopRequest<CrmGroupDeleteResponse>
    {
        /// <summary>
        /// 要删除的分组id<br /> 支持最小值为：1<br /> 支持的最大列表长度为：19
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.group.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("group_id", this.GroupId);
            RequestValidator.ValidateMinValue("group_id", this.GroupId, 1);
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
