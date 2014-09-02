using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.dealer.requisitionorder.get
    /// </summary>
    public class FenxiaoDealerRequisitionorderGetRequest : ITopRequest<FenxiaoDealerRequisitionorderGetResponse>
    {
        /// <summary>
        /// 采购申请/经销采购单最迟修改时间。与start_date字段的最大时间间隔不能超过30天
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// 多个字段用","分隔。 fields 如果为空：返回所有采购申请/经销采购单对象(dealer_orders)字段。 如果不为空：返回指定采购单对象(dealer_orders)字段。 例1： dealer_order_details.product_id 表示只返回product_id 例2： dealer_order_details 表示只返回明细列表
        /// </summary>
        public string Fields { get; set; }

        /// <summary>
        /// 查询者自己在所要查询的采购申请/经销采购单中的身份。  1：供应商。  2：分销商。  注：填写其他值当做错误处理。
        /// </summary>
        public Nullable<long> Identity { get; set; }

        /// <summary>
        /// 采购申请/经销采购单状态。  0：全部状态。  1：分销商提交申请，待供应商审核。  2：供应商驳回申请，待分销商确认。  3：供应商修改后，待分销商确认。  4：分销商拒绝修改，待供应商再审核。  5：审核通过下单成功，待分销商付款。  7：付款成功，待供应商发货。  8：供应商发货，待分销商收货。  9：分销商收货，交易成功。  10：采购申请/经销采购单关闭。    注：无值按默认值0计，超出状态范围返回错误信息。
        /// </summary>
        public Nullable<long> OrderStatus { get; set; }

        /// <summary>
        /// 页码（大于0的整数。无值或小于1的值按默认值1计）
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页条数（大于0但小于等于50的整数。无值或大于50或小于1的值按默认值50计）
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 采购申请/经销采购单最早修改时间
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.dealer.requisitionorder.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("fields", this.Fields);
            parameters.Add("identity", this.Identity);
            parameters.Add("order_status", this.OrderStatus);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_date", this.StartDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("identity", this.Identity);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
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
