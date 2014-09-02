using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.hanoi.function.execute
    /// </summary>
    public class HanoiFunctionExecuteRequest : ITopRequest<HanoiFunctionExecuteResponse>
    {
        /// <summary>
        /// 分配给调用方的名称信息，内部统计使用
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// Param的json格式，map中通常包括functionId,strategy 等所需业务参数
        /// </summary>
        public string Para { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.hanoi.function.execute";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("app_name", this.AppName);
            parameters.Add("para", this.Para);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_name", this.AppName);
            RequestValidator.ValidateRequired("para", this.Para);
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
