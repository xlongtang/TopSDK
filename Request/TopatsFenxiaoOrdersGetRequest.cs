using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.fenxiao.orders.get
    /// </summary>
    public class TopatsFenxiaoOrdersGetRequest : ITopRequest<TopatsFenxiaoOrdersGetResponse>
    {
        /// <summary>
        /// 结束时间 格式 yyyyMMdd表示yyyy-MM-dd 00:00:00.开始与结束时间不能超过90天。
        /// </summary>
        public string EndCreated { get; set; }

        /// <summary>
        /// 多个字段用","分隔。    fields  如果为空：返回所有采购单对象(purchase_orders)字段。  如果不为空：返回指定采购单对象(purchase_orders)字段。    例1：  sub_purchase_orders.tc_order_id 表示只返回tc_order_id   例2：  sub_purchase_orders表示只返回子采购单列表
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 起始时间 格式 yyyyMMdd表示yyyy-MM-dd 00:00:00.开始与结束时间不能超过90天且开始时间不能为90天前
        /// </summary>
        public string StartCreated { get; set; }

        /// <summary>
        /// 交易状态，不传默认查询所有采购单根据身份选择自身状态可选值:<br> *供应商：<br> WAIT_SELLER_SEND_GOODS(等待发货)<br> WAIT_SELLER_CONFIRM_PAY(待确认收款)<br> WAIT_BUYER_PAY(等待付款)<br> WAIT_BUYER_CONFIRM_GOODS(已发货)<br> TRADE_REFUNDING(退款中)<br> TRADE_FINISHED(采购成功)<br> TRADE_CLOSED(已关闭)<br> *分销商：<br> WAIT_BUYER_PAY(等待付款)<br> WAIT_BUYER_CONFIRM_GOODS(待收货确认)<br> TRADE_FOR_PAY(已付款)<br> TRADE_REFUNDING(退款中)<br> TRADE_FINISHED(采购成功)<br> TRADE_CLOSED(已关闭)<br>
        /// </summary>
        public string Status { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.fenxiao.orders.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_created", this.EndCreated);
            parameters.Add("fields", this.Fields);
            parameters.Add("start_created", this.StartCreated);
            parameters.Add("status", this.Status);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_created", this.EndCreated);
            RequestValidator.ValidateRequired("start_created", this.StartCreated);
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
