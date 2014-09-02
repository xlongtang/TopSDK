using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.datatemplate.query
    /// </summary>
    public class HanoiDatatemplateQueryRequest : ITopRequest<HanoiDatatemplateQueryResponse>
    {
        /// <summary>
        /// AppName
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// templateName:String 根据模板的名字查找  isNeedDetail：Boolean 是否返回模板详情  opened:int 开放策略  owner:创建者，填入appkey
        /// </summary>
        public string Parameter { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.datatemplate.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("parameter", this.Parameter);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
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
