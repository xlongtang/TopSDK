using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.extorder.page.get
    /// </summary>
    public class WlbExtorderPageGetRequest : ITopRequest<WlbExtorderPageGetResponse>
    {
        /// <summary>
        /// 查询截止时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 外部单据编号
        /// </summary>
        public string ExtOrderCode { get; set; }

        /// <summary>
        /// 外部订单来源： （1）EXT_LC：推荐物流 （2）EXT_WLB：wlb_ext （3）EXT_ERP：erp （4）EXT_WMS： WMS盘点 （5）EXT_FENXIAO：分销  (6) EXT_OMS: OMS （7）EXT_ELINK： ELINK
        /// </summary>
        public string ExtOrderSource { get; set; }

        /// <summary>
        /// 订单状态： DRAFT-订单已创建，CANCLE-订单已取消，CLOSED-订单关闭，SEND2WMS-下发中，WMS_RECEIVED-已下发，REJECT-接收方拒签，WMS_SEND-已发货，SIGNED-签收成功
        /// </summary>
        public string ExtOrderStatus { get; set; }

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
            return "taobao.wlb.extorder.page.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("ext_order_code", this.ExtOrderCode);
            parameters.Add("ext_order_source", this.ExtOrderSource);
            parameters.Add("ext_order_status", this.ExtOrderStatus);
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
