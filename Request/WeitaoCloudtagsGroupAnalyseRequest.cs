using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weitao.cloudtags.group.analyse
    /// </summary>
    public class WeitaoCloudtagsGroupAnalyseRequest : ITopRequest<WeitaoCloudtagsGroupAnalyseResponse>
    {
        /// <summary>
        /// 透视的sql
        /// </summary>
        public string AnalyzeExpression { get; set; }

        /// <summary>
        /// 分组sql信息
        /// </summary>
        public string GroupExpression { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weitao.cloudtags.group.analyse";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("analyze_expression", this.AnalyzeExpression);
            parameters.Add("group_expression", this.GroupExpression);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("analyze_expression", this.AnalyzeExpression);
            RequestValidator.ValidateRequired("group_expression", this.GroupExpression);
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
