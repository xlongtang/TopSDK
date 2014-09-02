using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trade.memo.update
    /// </summary>
    public class TradeMemoUpdateRequest : ITopRequest<TradeMemoUpdateResponse>
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
        /// 是否对memo的值置空  若为true，则不管传入的memo字段的值是否为空，都将会对已有的memo值清空，慎用；  若用false，则会根据memo是否为空来修改memo的值：若memo为空则忽略对已有memo字段的修改，若memo非空，则使用新传入的memo覆盖已有的memo的值
        /// </summary>
        public Nullable<bool> Reset { get; set; }

        /// <summary>
        /// 交易编号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trade.memo.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("flag", this.Flag);
            parameters.Add("memo", this.Memo);
            parameters.Add("reset", this.Reset);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("flag", this.Flag, 5);
            RequestValidator.ValidateMinValue("flag", this.Flag, 0);
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
