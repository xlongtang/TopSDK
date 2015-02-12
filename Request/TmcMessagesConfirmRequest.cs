using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tmc.messages.confirm
    /// </summary>
    public class TmcMessagesConfirmRequest : ITopRequest<TmcMessagesConfirmResponse>
    {
        /// <summary>
        /// 处理失败的消息ID列表--已废弃，无需传此字段
        /// </summary>
        public string FMessageIds { get; set; }

        /// <summary>
        /// 分组名称，不传代表默认分组
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 处理成功的消息ID列表 最大 200个ID
        /// </summary>
        public string SMessageIds { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.tmc.messages.confirm";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("f_message_ids", this.FMessageIds);
            parameters.Add("group_name", this.GroupName);
            parameters.Add("s_message_ids", this.SMessageIds);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxListSize("f_message_ids", this.FMessageIds, 200);
            RequestValidator.ValidateRequired("s_message_ids", this.SMessageIds);
            RequestValidator.ValidateMaxListSize("s_message_ids", this.SMessageIds, 200);
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
