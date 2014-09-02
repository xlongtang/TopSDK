using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.group.move
    /// </summary>
    public class CrmGroupMoveRequest : ITopRequest<CrmGroupMoveResponse>
    {
        /// <summary>
        /// 需要移动的分组<br /> 支持最小值为：1<br /> 支持的最大列表长度为：19
        /// </summary>
        public Nullable<long> FromGroupId { get; set; }

        /// <summary>
        /// 目的分组<br /> 支持最小值为：1<br /> 支持的最大列表长度为：19
        /// </summary>
        public Nullable<long> ToGroupId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.group.move";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("from_group_id", this.FromGroupId);
            parameters.Add("to_group_id", this.ToGroupId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("from_group_id", this.FromGroupId);
            RequestValidator.ValidateMinValue("from_group_id", this.FromGroupId, 1);
            RequestValidator.ValidateRequired("to_group_id", this.ToGroupId);
            RequestValidator.ValidateMinValue("to_group_id", this.ToGroupId, 1);
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
