using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.bill.bills.get
    /// </summary>
    public class BillBillsGetRequest : ITopRequest<BillBillsGetResponse>
    {
        /// <summary>
        /// 科目编号
        /// </summary>
        public Nullable<long> AccountId { get; set; }

        /// <summary>
        /// 结束时间,限制:结束时间-开始时间不能大于1天(根据order_id或者trade_id查询除外)
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 传入需要返回的字段,参见Bill结构体
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 子订单编号
        /// </summary>
        public Nullable<long> OrderId { get; set; }

        /// <summary>
        /// 页数,建议不要超过100页,越大性能越低,有可能会超时
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页大小,默认40条,可选范围 ：40~100
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 查询条件中的时间类型:1-交易订单完成时间biz_time 2-支付宝扣款时间pay_time 如果不填默认为2即根据支付时间查询,查询的结果会根据该时间倒排序
        /// </summary>
        public Nullable<long> TimeType { get; set; }

        /// <summary>
        /// 交易编号
        /// </summary>
        public Nullable<long> TradeId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.bill.bills.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("account_id", this.AccountId);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("fields", this.Fields);
            parameters.Add("order_id", this.OrderId);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("time_type", this.TimeType);
            parameters.Add("trade_id", this.TradeId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("fields", this.Fields);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
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
