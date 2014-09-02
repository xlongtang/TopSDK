using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.order.create
    /// </summary>
    public class WlbOrderCreateRequest : ITopRequest<WlbOrderCreateResponse>
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        public string AlipayNo { get; set; }

        /// <summary>
        /// 该字段暂时保留
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// 买家呢称
        /// </summary>
        public string BuyerNick { get; set; }

        /// <summary>
        /// 期望结束时间，在入库单会使用到
        /// </summary>
        public Nullable<DateTime> ExpectEndTime { get; set; }

        /// <summary>
        /// 计划开始送达时间  在入库单中可能会使用
        /// </summary>
        public Nullable<DateTime> ExpectStartTime { get; set; }

        /// <summary>
        /// {"invoince_info": [{"bill_type":"发票类型，必选", "bill_title":"发票抬头，必选", "bill_amount":"发票金额(单位是分)，必选","bill_content":"发票内容，可选"}]}
        /// </summary>
        public string InvoinceInfo { get; set; }

        /// <summary>
        /// 该物流宝订单是否已完成，如果完成则设置为true，如果为false，则需要等待继续创建订单商品信息。
        /// </summary>
        public Nullable<bool> IsFinished { get; set; }

        /// <summary>
        /// 物流宝订单编号，该接口约定每次最多只能传50条order_item_list，如果一个物流宝订单超过50条商品的时候，需要批量来调用该接口，第一次调用的时候，wlb_order_code为空，如果第一次创建成功，该接口返回wlb_order_code，其后继续再该订单上添加商品条目，需要带上wlb_order_code，out_biz_code，order_item_list,is_finished四个字段。
        /// </summary>
        public string OrderCode { get; set; }

        /// <summary>
        /// 用字符串格式来表示订单标记列表：比如COD^PRESELL^SPLIT^LIMIT 等，中间用“^”来隔开 ---------------------------------------- 订单标记list（所有字母全部大写）： 1: COD –货到付款 2: LIMIT-限时配送 3: PRESELL-预售 5:COMPLAIN-已投诉 7:SPLIT-拆单， 8:EXCHANGE-换货， 9:VISIT-上门 ， 10: MODIFYTRANSPORT-是否可改配送方式，  : 是否可改配送方式  默认可更改  11 CONSIGN 物流宝代理发货,自动更改发货状态  12: SELLER_AFFORD 是否卖家承担运费 默认是，即没 13: SYNC_RETURN_BILL，同时退回发票
        /// </summary>
        public string OrderFlag { get; set; }

        /// <summary>
        /// 订单商品列表： {"order_item_list":[{"trade_code":"可选,淘宝交易订单，并且不是赠品，必须要传订单来源编号"," sub_trade_code ":"可选,淘宝子交易号","item_id":"必须,商品Id","item_code":"必须,商家编码","item_name":"可选,物流宝商品名称","item_quantity":"必选,计划数量","item_price":"必选,物品价格,单位为分","owner_user_nick ":"可选,货主nick 代销模式下会存在","flag":"判断是否为赠品0 不是1是","remarks":"可选,备注","batch_remark":"可选，批次描述信息会把这个信息带给WMS，但不会跟物流宝库存相关联"，"inventory_type":"库存类型1 可销售库存 101 类型用来定义残次品 201 冻结类型库存 301 在途库存","picture_url":"图片Url","distributor_user_nick": "分销商NICK",必选"ext_order_item_code":"可选，外部商品的商家编码"]} ======================================== 如果订单中的商品条目数大于50条的时候，我们会校验，不能创建成功，需要你按照50个一批的数量传，需要分批调用该接口，第二次传的时候，需要带上wlb_order_code和is_finished和order_item_list三个字段是必传的，is_finished为true表示传输完毕，为false表示还没完全传完。
        /// </summary>
        public string OrderItemList { get; set; }

        /// <summary>
        /// 订单子类型：  （1）OTHER： 其他  （2）TAOBAO_TRADE： 淘宝交易  （3）OTHER_TRADE：其他交易  （4）ALLCOATE： 调拨  （5）PURCHASE:采购
        /// </summary>
        public string OrderSubType { get; set; }

        /// <summary>
        /// 订单类型:  （1）NORMAL_OUT ：正常出库  （2）NORMAL_IN：正常入库  （3）RETURN_IN：退货入库  （4）EXCHANGE_OUT：换货出库
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单业务ID，该编号在isv中是唯一编号， 用来控制并发，去重用
        /// </summary>
        public string OutBizCode { get; set; }

        /// <summary>
        /// 包裹件数，入库单和出库单中会用到
        /// </summary>
        public Nullable<long> PackageCount { get; set; }

        /// <summary>
        /// 应收金额，cod订单必选
        /// </summary>
        public Nullable<long> PayableAmount { get; set; }

        /// <summary>
        /// 源订单编号
        /// </summary>
        public string PrevOrderCode { get; set; }

        /// <summary>
        /// 发收方发货方信息必须传 手机和电话必选其一 收货方信息 邮编^^^省^^^市^^^区^^^具体地址^^^收件方名称^^^手机^^^电话  如果某一个字段的数据为空时，必须传NA
        /// </summary>
        public string ReceiverInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 投递时间范围要求,格式'15:20'用分号隔开
        /// </summary>
        public string ScheduleEnd { get; set; }

        /// <summary>
        /// 投递时间范围要求,格式'13:20'用分号隔开
        /// </summary>
        public string ScheduleStart { get; set; }

        /// <summary>
        /// 投递时延要求:   （1）INSTANT_ARRIVED： 当日达   （2）TOMMORROY_MORNING_ARRIVED：次晨达  （3）TOMMORROY_ARRIVED：次日达  （4）工作日：WORK_DAY   （5）节假日：WEEKED_DAY
        /// </summary>
        public string ScheduleType { get; set; }

        /// <summary>
        /// 发货方信息，发收方发货方信息必须传 手机和电话必选其一 邮编^^^省^^^市^^^区^^^具体地址^^^收件方名称^^^手机^^^电话 如果某一个字段的数据为空时，必须传NA
        /// </summary>
        public string SenderInfo { get; set; }

        /// <summary>
        /// cod服务费，只有cod订单的时候，才需要这个字段
        /// </summary>
        public Nullable<long> ServiceFee { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        public string StoreCode { get; set; }

        /// <summary>
        /// 出库单中可能会用到  运输公司名称^^^运输公司联系人^^^运输公司运单号^^^运输公司电话^^^运输公司联系人身份证号    ========================================  如果某一个字段的数据为空时，必须传NA
        /// </summary>
        public string TmsInfo { get; set; }

        /// <summary>
        /// 运单编号，退货单时可能会使用
        /// </summary>
        public string TmsOrderCode { get; set; }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        public string TmsServiceCode { get; set; }

        /// <summary>
        /// 总金额
        /// </summary>
        public Nullable<long> TotalAmount { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.order.create";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alipay_no", this.AlipayNo);
            parameters.Add("attributes", this.Attributes);
            parameters.Add("buyer_nick", this.BuyerNick);
            parameters.Add("expect_end_time", this.ExpectEndTime);
            parameters.Add("expect_start_time", this.ExpectStartTime);
            parameters.Add("invoince_info", this.InvoinceInfo);
            parameters.Add("is_finished", this.IsFinished);
            parameters.Add("order_code", this.OrderCode);
            parameters.Add("order_flag", this.OrderFlag);
            parameters.Add("order_item_list", this.OrderItemList);
            parameters.Add("order_sub_type", this.OrderSubType);
            parameters.Add("order_type", this.OrderType);
            parameters.Add("out_biz_code", this.OutBizCode);
            parameters.Add("package_count", this.PackageCount);
            parameters.Add("payable_amount", this.PayableAmount);
            parameters.Add("prev_order_code", this.PrevOrderCode);
            parameters.Add("receiver_info", this.ReceiverInfo);
            parameters.Add("remark", this.Remark);
            parameters.Add("schedule_end", this.ScheduleEnd);
            parameters.Add("schedule_start", this.ScheduleStart);
            parameters.Add("schedule_type", this.ScheduleType);
            parameters.Add("sender_info", this.SenderInfo);
            parameters.Add("service_fee", this.ServiceFee);
            parameters.Add("store_code", this.StoreCode);
            parameters.Add("tms_info", this.TmsInfo);
            parameters.Add("tms_order_code", this.TmsOrderCode);
            parameters.Add("tms_service_code", this.TmsServiceCode);
            parameters.Add("total_amount", this.TotalAmount);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("buyer_nick", this.BuyerNick, 64);
            RequestValidator.ValidateRequired("is_finished", this.IsFinished);
            RequestValidator.ValidateRequired("order_item_list", this.OrderItemList);
            RequestValidator.ValidateRequired("order_sub_type", this.OrderSubType);
            RequestValidator.ValidateRequired("order_type", this.OrderType);
            RequestValidator.ValidateRequired("out_biz_code", this.OutBizCode);
            RequestValidator.ValidateMaxLength("out_biz_code", this.OutBizCode, 128);
            RequestValidator.ValidateMaxLength("remark", this.Remark, 4000);
            RequestValidator.ValidateRequired("store_code", this.StoreCode);
            RequestValidator.ValidateMaxLength("store_code", this.StoreCode, 64);
            RequestValidator.ValidateMaxLength("tms_service_code", this.TmsServiceCode, 64);
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
