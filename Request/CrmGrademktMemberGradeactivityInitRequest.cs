using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.crm.grademkt.member.gradeactivity.init
    /// </summary>
    public class CrmGrademktMemberGradeactivityInitRequest : ITopRequest<CrmGrademktMemberGradeactivityInitResponse>
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        public string Feather { get; set; }

        /// <summary>
        /// 活动名称，不传默认为“等级营销”
        /// </summary>
        public string Parameter { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.crm.grademkt.member.gradeactivity.init";
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
