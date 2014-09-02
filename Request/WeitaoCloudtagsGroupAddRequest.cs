using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weitao.cloudtags.group.add
    /// </summary>
    public class WeitaoCloudtagsGroupAddRequest : ITopRequest<WeitaoCloudtagsGroupAddResponse>
    {
        /// <summary>
        /// 分组的sql
        /// </summary>
        public string Expression { get; set; }

        /// <summary>
        /// 组的描述<br /> 支持最大长度为：100<br /> 支持的最大列表长度为：100
        /// </summary>
        public string GroupDesc { get; set; }

        /// <summary>
        /// 组的名字<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string GroupName { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weitao.cloudtags.group.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("expression", this.Expression);
            parameters.Add("group_desc", this.GroupDesc);
            parameters.Add("group_name", this.GroupName);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("expression", this.Expression);
            RequestValidator.ValidateRequired("group_desc", this.GroupDesc);
            RequestValidator.ValidateMaxLength("group_desc", this.GroupDesc, 100);
            RequestValidator.ValidateRequired("group_name", this.GroupName);
            RequestValidator.ValidateMaxLength("group_name", this.GroupName, 32);
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
