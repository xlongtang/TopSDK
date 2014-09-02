using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sellercenter.subuser.permissions.roles.get
    /// </summary>
    public class SellercenterSubuserPermissionsRolesGetRequest : ITopRequest<SellercenterSubuserPermissionsRolesGetResponse>
    {
        /// <summary>
        /// 子账号昵称(子账号标识)<br /> 支持最大长度为：100<br /> 支持的最大列表长度为：100
        /// </summary>
        public string Nick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sellercenter.subuser.permissions.roles.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("nick", this.Nick);
            RequestValidator.ValidateMaxLength("nick", this.Nick, 100);
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
