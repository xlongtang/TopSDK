using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.notify.message.page.get
    /// </summary>
    public class WlbNotifyMessagePageGetRequest : ITopRequest<WlbNotifyMessagePageGetResponse>
    {
        /// <summary>
        /// 查询条件：记录截至时间
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// 通知消息编码：  STOCK_IN_NOT_CONSISTENT---入库单不一致  CANCEL_ORDER_SUCCESS---取消订单成功  INVENTORY_CHECK---盘点  CANCEL_ORDER_FAILURE---取消订单失败  ORDER_REJECT--wms拒单  ORDER_CONFIRMED--订单处理成功
        /// </summary>
        public string MsgCode { get; set; }

        /// <summary>
        /// 分页查询页数
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 分页查询的每页页数
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询条件：记录开始时间
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        /// <summary>
        /// 消息状态：  不需要确认：NO_NEED_CONFIRM  已确认：CONFIRMED  待确认：TO_BE_CONFIRM
        /// </summary>
        public string Status { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.notify.message.page.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("msg_code", this.MsgCode);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_date", this.StartDate);
            parameters.Add("status", this.Status);
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
