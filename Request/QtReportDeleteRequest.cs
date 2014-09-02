using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.qt.report.delete
    /// </summary>
    public class QtReportDeleteRequest : ITopRequest<QtReportDeleteResponse>
    {
        /// <summary>
        /// 一个质检服务唯一标识质量检验单的编号<br /> 支持最大长度为：64<br /> 支持的最大列表长度为：64
        /// </summary>
        public string QtCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.qt.report.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("qt_code", this.QtCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("qt_code", this.QtCode);
            RequestValidator.ValidateMaxLength("qt_code", this.QtCode, 64);
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
