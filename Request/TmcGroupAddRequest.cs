using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tmc.group.add
    /// </summary>
    public class TmcGroupAddRequest : ITopRequest<TmcGroupAddResponse>
    {
        /// <summary>
        /// 分组名称，同一个应用下需要保证唯一性，最长32个字符。添加分组后，消息通道会为用户的消息分配独立分组，但之前的消息还是存储于默认分组中。不能以default开头，default开头为系统默认组。<br /> 支持最大长度为：32<br /> 支持的最大列表长度为：32
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 用户昵称列表，以半角逗号分隔，支持子账号，支持增量添加用户
        /// </summary>
        public string Nicks { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.tmc.group.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_name", this.GroupName);
            parameters.Add("nicks", this.Nicks);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("group_name", this.GroupName);
            RequestValidator.ValidateMaxLength("group_name", this.GroupName, 32);
            RequestValidator.ValidateRequired("nicks", this.Nicks);
            RequestValidator.ValidateMaxListSize("nicks", this.Nicks, 200);
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
