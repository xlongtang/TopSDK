using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.grademkt.member.detail.query
    /// </summary>
    public class CrmGrademktMemberDetailQueryRequest : ITopRequest<CrmGrademktMemberDetailQueryResponse>
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Feather { get; set; }

        /// <summary>
        /// 创建营销详情，生成方法见http://open.taobao.com/doc/detail.htm?id=101281
        /// </summary>
        public string Parameter { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.grademkt.member.detail.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("feather", this.Feather);
            parameters.Add("parameter", this.Parameter);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
