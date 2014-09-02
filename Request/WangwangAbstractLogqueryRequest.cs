using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wangwang.abstract.logquery
    /// </summary>
    public class WangwangAbstractLogqueryRequest : ITopRequest<WangwangAbstractLogqueryResponse>
    {
        /// <summary>
        /// 传入参数的字符集
        /// </summary>
        public string Charset { get; set; }

        /// <summary>
        /// 获取记录条数，默认值是1000
        /// </summary>
        public Nullable<long> Count { get; set; }

        /// <summary>
        /// 东八区时间
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 卖家id，有cntaobao前缀
        /// </summary>
        public string FromId { get; set; }

        /// <summary>
        /// 设置了这个值，那么聊天记录就从这个点开始查询
        /// </summary>
        public string NextKey { get; set; }

        /// <summary>
        /// 东八区时间
        /// </summary>
        public string StartDate { get; set; }

        /// <summary>
        /// 买家id，有cntaobao前缀
        /// </summary>
        public string ToId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wangwang.abstract.logquery";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("charset", this.Charset);
            parameters.Add("count", this.Count);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("from_id", this.FromId);
            parameters.Add("next_key", this.NextKey);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("to_id", this.ToId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("count", this.Count, 1);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("from_id", this.FromId);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
            RequestValidator.ValidateRequired("to_id", this.ToId);
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
