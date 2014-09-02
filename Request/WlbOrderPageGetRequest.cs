using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.order.page.get
    /// </summary>
    public class WlbOrderPageGetRequest : ITopRequest<WlbOrderPageGetResponse>
    {
        /// <summary>
        /// 查询截止时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 物流订单编号
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        public Nullable<long> OrderStatus { get; set; }

        /// <summary>
        /// 订单子类型：   （1）OTHER： 其他   （2）TAOBAO_TRADE： 淘宝交易   （3）OTHER_TRADE：其他交易  （4）ALLCOATE： 调拨  （5）CHECK:  盘点单  （6）PURCHASE: 采购单
        /// </summary>
        public string OrderSubType { get; set; }

        /// <summary>
        /// 订单类型:   （1）NORMAL_OUT ：正常出库   （2）NORMAL_IN：正常入库   （3）RETURN_IN：退货入库   （4）EXCHANGE_OUT：换货出库
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 分页的第几页
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页多少条
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.order.page.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("order_code", this.OrderCode);
            parameters.Add("order_status", this.OrderStatus);
            parameters.Add("order_sub_type", this.OrderSubType);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_time", this.StartTime);
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
