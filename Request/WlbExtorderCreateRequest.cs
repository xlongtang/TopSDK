using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.extorder.create
    /// </summary>
    public class WlbExtorderCreateRequest : ITopRequest<WlbExtorderCreateResponse>
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 期望结束时间，在入库单会使用到
        /// </summary>
        public Nullable<DateTime> ExpectEndTime { get; set; }

        /// <summary>
        /// 计划开始送达时间 在入库单中可能会使用
        /// </summary>
        public Nullable<DateTime> ExpectStartTime { get; set; }

        /// <summary>
        /// 用字符串格式来表示订单标记列表：比如COD^PRESELL^SPLIT^LIMIT 等，中间用“^”来隔开 ---------------------------------------- 订单标记list（所有字母全部大写）1:COD-货到付款,2:LIMIT-限时配送,3:PRESELL-预售,4:INVOICE-需要发票,5:COMPLAIN-已投诉,6:MERGE-合单,7:SPLIT-拆单,8: EXCHANGE-退换货， 9:VISIT-上门 ,10:MODIFYTRANSPORT-可改配送方式,11:CONSIGN-代理已发货通知, 12:SELLER_AFFORD-卖家承担运费,13:SYNC_RETURN_BILL-同时退回发票,14: FENXIAO-分销订单标志
        /// </summary>
        public string ExtFlag { get; set; }

        /// <summary>
        /// 外部单据编号
        /// </summary>
        public string ExtOrderCode { get; set; }

        /// <summary>
        /// 外部订单来源： （1）LC：推荐物流 （2）EXT：wlb_ext （3）ERP：erp （4）WMS： WMS盘点 （5）FENXIAO：分销  (6) OMS: OMS （7）ELINK： ELINK
        /// </summary>
        public string ExtOrderSource { get; set; }

        /// <summary>
        /// 引起当前单据的前一个单据的编号
        /// </summary>
        public string ExtPrevOrderId { get; set; }

        /// <summary>
        /// {"invoince_info": [{"bill_type":"发票类型，必选", "bill_title":"发票抬头，必选", "bill_amount":"发票金额(单位是分)，必选","bill_content":"发票内容，可选"}]}
        /// </summary>
        public string InvoinceInfo { get; set; }

        /// <summary>
        /// 1:NORM-正常订单,2:RETURN-退货订单,3:SWITCH-换货订单
        /// </summary>
        public string OpMainType { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        public string OperateCode { get; set; }

        /// <summary>
        /// 订单类型： （1）OTHER： 其他 （2）TBTRADE： 淘宝交易 （3）OTHER_TRADE：其他交易 （4）COORDINATE：调拨（5）ALLOCATION： 盘点 （6）STOCK:采购
        /// </summary>
        public string OperateType { get; set; }

        /// <summary>
        /// 订单商品列表： {"order_item_list":[{" sub_trade_code ":"可选,淘宝子交易号","item_id":"必须,商品Id","item_code":"必须,商家编码","item_name":"可选,物流宝商品名称","item_quantity":"必选,计划数量","item_price":"必选,物品价格,单位为分","owner_user_nick ":"可选,货主nick 代销模式下会存在","flag":"判断是否为赠品0 不是1是","picture_url":"图片Url","remarks":"可选,备注","inventory_type":"必须，库存类型1 可销售库存 101 类型用来定义残次品 201 冻结类型库存 301 在途库存"]}
        /// </summary>
        public string OrderItemList { get; set; }

        /// <summary>
        /// 订单类型：（1）INBOUND：入库（2）OUTBOUND：出库（3）ALLOCATE：调拨（4）RETURN_IN:退货入库
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 包裹件数，入库单和出库单中会用到
        /// </summary>
        public Nullable<long> PackageCount { get; set; }

        /// <summary>
        /// 运费，以分为单位
        /// </summary>
        public Nullable<long> Postage { get; set; }

        /// <summary>
        /// 发收方发货方信息必须传 手机和电话必选其一 收货方信息 邮编^^^省^^^市^^^区^^^具体地址^^^收件方名称^^^手机^^^电话 如果某一个字段的数据为空时，必须传NA
        /// </summary>
        public string ReceiverInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 零售商
        /// </summary>
        public string Retailer { get; set; }

        /// <summary>
        /// 退货时的运单号
        /// </summary>
        public string ReturnTmsCode { get; set; }

        /// <summary>
        /// 投递时间范围要求,格式'15:20'用分号隔开
        /// </summary>
        public string ScheduleEnd { get; set; }

        /// <summary>
        /// 投递时间范围要求,格式'13:20'用分号隔开
        /// </summary>
        public string ScheduleStart { get; set; }

        /// <summary>
        /// 投递时延要求: （1）INSTANT_ARRIVED： 当日达 （2）TOMMORROY_MORNING_ARRIVED：次晨达 （3）TOMMORROY_ARRIVED：次日达 （4）工作日：WORK_DAY （5）节假日：WEEKED_DAY
        /// </summary>
        public string ScheduleType { get; set; }

        /// <summary>
        /// 发货方信息，发收方发货方信息必须传 手机和电话必选其一 邮编^^^省^^^市^^^区^^^具体地址^^^收件方名称^^^手机^^^电话 如果某一个字段的数据为空时，必须传NA
        /// </summary>
        public string SenderInfo { get; set; }

        /// <summary>
        /// 服务费用，以分为单位
        /// </summary>
        public Nullable<long> ServiceFee { get; set; }

        /// <summary>
        /// 物流运送方式: （1）MAIL:平邮 （2）EXPRESS :快递？ (3) EMS: EMS (4) OTHER:其他
        /// </summary>
        public string ShippingType { get; set; }

        /// <summary>
        /// 子订单外部订单编号
        /// </summary>
        public string SubExtOrderCode { get; set; }

        /// <summary>
        /// 快递公司的代码
        /// </summary>
        public string TmsCode { get; set; }

        /// <summary>
        /// 卖家建议的物流公司编码,或者退货时的发货公司编码
        /// </summary>
        public string TmsTpCode { get; set; }

        /// <summary>
        /// 物品总价，以分为单位
        /// </summary>
        public Nullable<long> TotalPrice { get; set; }

        /// <summary>
        /// 交易订单类型，1：MAIN-表示主订单，2：SUB-表示子订单
        /// </summary>
        public string TradeOrderType { get; set; }

        /// <summary>
        /// 仓库的代码
        /// </summary>
        public string WmsCode { get; set; }

        /// <summary>
        /// 调拨单目地仓库
        /// </summary>
        public string WmsCodeDestination { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.extorder.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("expect_end_time", this.ExpectEndTime);
            parameters.Add("expect_start_time", this.ExpectStartTime);
            parameters.Add("ext_flag", this.ExtFlag);
            parameters.Add("ext_order_code", this.ExtOrderCode);
            parameters.Add("ext_order_source", this.ExtOrderSource);
            parameters.Add("ext_prev_order_id", this.ExtPrevOrderId);
            parameters.Add("invoince_info", this.InvoinceInfo);
            parameters.Add("op_main_type", this.OpMainType);
            parameters.Add("operate_code", this.OperateCode);
            parameters.Add("operate_type", this.OperateType);
            parameters.Add("order_item_list", this.OrderItemList);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("package_count", this.PackageCount);
            parameters.Add("postage", this.Postage);
            parameters.Add("receiver_info", this.ReceiverInfo);
            parameters.Add("remark", this.Remark);
            parameters.Add("retailer", this.Retailer);
            parameters.Add("return_tms_code", this.ReturnTmsCode);
            parameters.Add("schedule_end", this.ScheduleEnd);
            parameters.Add("schedule_start", this.ScheduleStart);
            parameters.Add("schedule_type", this.ScheduleType);
            parameters.Add("sender_info", this.SenderInfo);
            parameters.Add("service_fee", this.ServiceFee);
            parameters.Add("shipping_type", this.ShippingType);
            parameters.Add("sub_ext_order_code", this.SubExtOrderCode);
            parameters.Add("tms_code", this.TmsCode);
            parameters.Add("tms_tp_code", this.TmsTpCode);
            parameters.Add("total_price", this.TotalPrice);
            parameters.Add("trade_order_type", this.TradeOrderType);
            parameters.Add("wms_code", this.WmsCode);
            parameters.Add("wms_code_destination", this.WmsCodeDestination);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("ext_order_code", this.ExtOrderCode);
            RequestValidator.ValidateRequired("ext_order_source", this.ExtOrderSource);
            RequestValidator.ValidateRequired("operate_type", this.OperateType);
            RequestValidator.ValidateRequired("order_item_list", this.OrderItemList);
            RequestValidator.ValidateRequired("order_type", this.OrderType);
            RequestValidator.ValidateRequired("retailer", this.Retailer);
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
