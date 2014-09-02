using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wangwang.abstract.deleteword
    /// </summary>
    public class WangwangAbstractDeletewordRequest : ITopRequest<WangwangAbstractDeletewordResponse>
    {
        /// <summary>
        /// 传入参数的字符集
        /// </summary>
        public string Charset { get; set; }

        /// <summary>
        /// 关键词，长度大于0
        /// </summary>
        public string Word { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wangwang.abstract.deleteword";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("charset", this.Charset);
            parameters.Add("word", this.Word);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("word", this.Word);
            RequestValidator.ValidateMaxLength("word", this.Word, 12);
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
