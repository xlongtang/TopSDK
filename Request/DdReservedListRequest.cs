using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.dd.reserved.list
    /// </summary>
    public class DdReservedListRequest : ITopRequest<DdReservedListResponse>
    {
        /// <summary>
        /// 买家称呼
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家预定手机号
        /// </summary>
        public string BuyerPhone { get; set; }

        /// <summary>
        /// 预定结束时间
        /// </summary>
        public Nullable<DateTime> Ends { get; set; }

        /// <summary>
        /// 打印状态    * 0 : 未打印    * 1 : 已打印    * 2 : 已处理
        /// </summary>
        public Nullable<long> Option { get; set; }

        /// <summary>
        /// 翻页游码
        /// </summary>
        public Nullable<long> Pn { get; set; }

        /// <summary>
        /// 页面大小
        /// </summary>
        public Nullable<long> Ps { get; set; }

        /// <summary>
        /// 预定开始时间
        /// </summary>
        public Nullable<DateTime> Starts { get; set; }

        /// <summary>
        /// 淘宝商户id
        /// </summary>
        public string StoreId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.dd.reserved.list";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("buyer_phone", this.BuyerPhone);
            parameters.Add("ends", this.Ends);
            parameters.Add("option", this.Option);
            parameters.Add("pn", this.Pn);
            parameters.Add("ps", this.Ps);
            parameters.Add("starts", this.Starts);
            parameters.Add("store_id", this.StoreId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
