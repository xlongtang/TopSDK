using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.memo.add
    /// </summary>
    public class TradeMemoAddRequest : ITopRequest<TradeMemoAddResponse>
    {
        /// <summary>
        /// 交易备注旗帜，可选值为：0(灰色), 1(红色), 2(黄色), 3(绿色), 4(蓝色), 5(粉红色)，默认值为0
        /// </summary>
        public Nullable<long> Flag { get; set; }

        /// <summary>
        /// 交易备注。最大长度: 1000个字节
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 交易编号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.memo.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("flag", this.Flag);
            parameters.Add("memo", this.Memo);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("flag", this.Flag, 5);
            RequestValidator.ValidateMinValue("flag", this.Flag, 0);
            RequestValidator.ValidateRequired("memo", this.Memo);
            RequestValidator.ValidateRequired("tid", this.Tid);
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
