using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.catsrelatedword.get
    /// </summary>
    public class SimbaInsightCatsrelatedwordGetRequest : ITopRequest<SimbaInsightCatsrelatedwordGetResponse>
    {
        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 最大返回数量(1-10)
        /// </summary>
        public Nullable<long> ResultNum { get; set; }

        /// <summary>
        /// 查询词数组，最大长度200
        /// </summary>
        public string Words { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.catsrelatedword.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("result_num", this.ResultNum);
            parameters.Add("words", this.Words);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("result_num", this.ResultNum);
            RequestValidator.ValidateMaxValue("result_num", this.ResultNum, 10);
            RequestValidator.ValidateMinValue("result_num", this.ResultNum, 1);
            RequestValidator.ValidateRequired("words", this.Words);
            RequestValidator.ValidateMaxListSize("words", this.Words, 200);
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
