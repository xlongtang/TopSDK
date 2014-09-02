using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.traderate.explain.add
    /// </summary>
    public class TraderateExplainAddRequest : ITopRequest<TraderateExplainAddResponse>
    {
        /// <summary>
        /// 子订单ID
        /// </summary>
        public Nullable<long> Oid { get; set; }

        /// <summary>
        /// 评价解释内容,最大长度: 500个汉字
        /// </summary>
        public string Reply { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.traderate.explain.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("oid", this.Oid);
            parameters.Add("reply", this.Reply);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("oid", this.Oid);
            RequestValidator.ValidateRequired("reply", this.Reply);
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
