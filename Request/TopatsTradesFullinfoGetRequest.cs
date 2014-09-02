using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.trades.fullinfo.get
    /// </summary>
    public class TopatsTradesFullinfoGetRequest : ITopRequest<TopatsTradesFullinfoGetResponse>
    {
        /// <summary>
        /// 可以返回taobao.trade.fullinfo.get允许的所有字段。
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 交易订单号tid列表，多个tid之间用半角分号分隔。tid个数的取值范围是：1~100个。由于这个接口限制每个应用的调用量是3万次/天，所以强烈建议采用尽可能多的tid，以取到更多的交易数据。
        /// </summary>
        public string Tids { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.trades.fullinfo.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("fields", this.Fields);
            parameters.Add("tids", this.Tids);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("tids", this.Tids);
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
