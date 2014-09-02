using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.logistics.trace.search
    /// </summary>
    public class LogisticsTraceSearchRequest : ITopRequest<LogisticsTraceSearchResponse>
    {
        /// <summary>
        /// 表明是否是拆单，默认值0，1表示拆单
        /// </summary>
        public Nullable<long> IsSplit { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 拆单子订单列表，对应的数据是：子订单号的列表。可以不传，但是如果传了则必须符合传递的规则。子订单必须是操作的物流订单的子订单的真子集
        /// </summary>
        public string SubTid { get; set; }

        /// <summary>
        /// 淘宝交易号，请勿传非淘宝交易号
        /// </summary>
        public Nullable<long> Tid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.logistics.trace.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("is_split", this.IsSplit);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("sub_tid", this.SubTid);
            parameters.Add("tid", this.Tid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("seller_nick", this.SellerNick);
            RequestValidator.ValidateMaxListSize("sub_tid", this.SubTid, 50);
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
