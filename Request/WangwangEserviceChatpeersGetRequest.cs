using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wangwang.eservice.chatpeers.get
    /// </summary>
    public class WangwangEserviceChatpeersGetRequest : ITopRequest<WangwangEserviceChatpeersGetResponse>
    {
        /// <summary>
        /// 字符集
        /// </summary>
        public string Charset { get; set; }

        /// <summary>
        /// 聊天用户ID：cntaobao+淘宝nick，例如cntaobaotest
        /// </summary>
        public string ChatId { get; set; }

        /// <summary>
        /// 查询结束日期。如2010-03-24，与起始日期跨度不能超过7天
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 查询起始日期。如2010-02-01，与当前日期间隔小于1个月。
        /// </summary>
        public string StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wangwang.eservice.chatpeers.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("charset", this.Charset);
            parameters.Add("chat_id", this.ChatId);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("start_date", this.StartDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("chat_id", this.ChatId);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
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
