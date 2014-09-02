using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.group.add
    /// </summary>
    public class CrmGroupAddRequest : ITopRequest<CrmGroupAddResponse>
    {
        /// <summary>
        /// 分组名称，每个卖家最多可以拥有100个分组<br /> 支持最大长度为：15<br /> 支持的最大列表长度为：15
        /// </summary>
        public string GroupName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.group.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_name", this.GroupName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("group_name", this.GroupName);
            RequestValidator.ValidateMaxLength("group_name", this.GroupName, 15);
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
