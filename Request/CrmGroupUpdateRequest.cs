using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.group.update
    /// </summary>
    public class CrmGroupUpdateRequest : ITopRequest<CrmGroupUpdateResponse>
    {
        /// <summary>
        /// 分组的id<br /> 支持最小值为：1<br /> 支持的最大列表长度为：19
        /// </summary>
        public Nullable<long> GroupId { get; set; }

        /// <summary>
        /// 新的分组名，分组名称不能包含|或者：<br /> 支持最大长度为：15<br /> 支持的最大列表长度为：15
        /// </summary>
        public string NewGroupName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.group.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_id", this.GroupId);
            parameters.Add("new_group_name", this.NewGroupName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("group_id", this.GroupId);
            RequestValidator.ValidateMinValue("group_id", this.GroupId, 1);
            RequestValidator.ValidateRequired("new_group_name", this.NewGroupName);
            RequestValidator.ValidateMaxLength("new_group_name", this.NewGroupName, 15);
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
