using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.grademkt.member.query
    /// </summary>
    public class CrmGrademktMemberQueryRequest : ITopRequest<CrmGrademktMemberQueryResponse>
    {
        /// <summary>
        /// 会员nick
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 系统属性，json格式
        /// </summary>
        public string Feather { get; set; }

        /// <summary>
        /// 会员属性-json format  生成方法见http://open.taobao.com/doc/detail.htm?id=101281
        /// </summary>
        public string Parameter { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.grademkt.member.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("feather", this.Feather);
            parameters.Add("parameter", this.Parameter);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("buyer_nick", this.BuyerNick);
            RequestValidator.ValidateRequired("feather", this.Feather);
            RequestValidator.ValidateRequired("parameter", this.Parameter);
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
