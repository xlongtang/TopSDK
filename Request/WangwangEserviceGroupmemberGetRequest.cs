using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wangwang.eservice.groupmember.get
    /// </summary>
    public class WangwangEserviceGroupmemberGetRequest : ITopRequest<WangwangEserviceGroupmemberGetResponse>
    {
        /// <summary>
        /// 主帐号ID：cntaobao+淘宝nick，例如cntaobaotest<br /> 支持最大长度为：128<br /> 支持的最大列表长度为：128
        /// </summary>
        public string ManagerId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wangwang.eservice.groupmember.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("manager_id", this.ManagerId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("manager_id", this.ManagerId);
            RequestValidator.ValidateMaxLength("manager_id", this.ManagerId, 128);
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
