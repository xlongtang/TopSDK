using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbOrder Data Structure.
    /// </summary>
    [Serializable]
    public class WlbOrder : TopObject
    {
        /// <summary>
        /// 买家nick
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 订单取消状态：  1-取消中；   2-取消失败；  3-取消完成
        /// </summary>
        [XmlElement("cancel_order_status")]
        public long CancelOrderStatus { get; set; }

        /// <summary>
        /// 确认状态：  (1)不需要确认：NO_NEED_CONFIRM  (2)等待确认：WAIT_CONFIRM  (3)已确认:CONFIRMED
        /// </summary>
        [XmlElement("confirm_status")]
        public string ConfirmStatus { get; set; }

        /// <summary>
        /// 计划送达结束时间
        /// </summary>
        [XmlElement("expect_end_time")]
        public string ExpectEndTime { get; set; }

        /// <summary>
        /// 计划送达开始时间
        /// </summary>
        [XmlElement("expect_start_time")]
        public string ExpectStartTime { get; set; }

        /// <summary>
        /// 发票信息
        /// </summary>
        [XmlElement("invoice_info")]
        public string InvoiceInfo { get; set; }

        /// <summary>
        /// 物流宝订单中的商品种类数量
        /// </summary>
        [XmlElement("item_kinds_count")]
        public long ItemKindsCount { get; set; }

        /// <summary>
        /// 出库或者入库，IN表示入库，OUT表示出库
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 订单编码
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 第1位:COD,2:限时配送,3:预售,4:需要发票,5:已投诉,第6位:合单,第7位:拆单 第8位：EXCHANGE-换货， 第9位:VISIT-上门 ， 第10位: MODIFYTRANSPORT-是否可改配送方式，第11位：是否物流代理确认发货
        /// </summary>
        [XmlElement("order_flag")]
        public long OrderFlag { get; set; }

        /// <summary>
        /// 订单来源:  产生物流订单的原因，比如:    订单来源:1:TAOBAO;2:EXT;3:ERP;4:WMS
        /// </summary>
        [XmlElement("order_source")]
        public string OrderSource { get; set; }

        /// <summary>
        /// 对应创建物流宝订单top接口中的的out_biz_code字段，主要是用来去重用
        /// </summary>
        [XmlElement("order_source_code")]
        public string OrderSourceCode { get; set; }

        /// <summary>
        /// 物流状态，  订单已创建：0  订单已取消: -1  订单关闭:-3  下发中: 10  已下发: 11  接收方拒签 :-100  已发货:100  签收成功:200
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 卖家取消,仓库取消标识
        /// </summary>
        [XmlElement("order_status_reason")]
        public string OrderStatusReason { get; set; }

        /// <summary>
        /// (1)其它:    OTHER  (2)淘宝交易: TAOBAO  (3)301:调拨: ALLOCATION  (4)401:盘点:CHECK  (5)501:销售采购:PRUCHASE
        /// </summary>
        [XmlElement("order_sub_type")]
        public string OrderSubType { get; set; }

        /// <summary>
        /// 1:正常订单: NARMAL  2:退货订单: RETURN  3:换货订单: CHANGE
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 原订单编码
        /// </summary>
        [XmlElement("prev_order_code")]
        public string PrevOrderCode { get; set; }

        /// <summary>
        /// 实际入库的种类数量
        /// </summary>
        [XmlElement("real_kinds_count")]
        public long RealKindsCount { get; set; }

        /// <summary>
        /// 应收金额
        /// </summary>
        [XmlElement("receivable_amount")]
        public long ReceivableAmount { get; set; }

        /// <summary>
        /// 收件人具体地址
        /// </summary>
        [XmlElement("receiver_address")]
        public string ReceiverAddress { get; set; }

        /// <summary>
        /// 区或者县
        /// </summary>
        [XmlElement("receiver_area")]
        public string ReceiverArea { get; set; }

        /// <summary>
        /// 收件人城市
        /// </summary>
        [XmlElement("receiver_city")]
        public string ReceiverCity { get; set; }

        /// <summary>
        /// 接收人电子邮箱
        /// </summary>
        [XmlElement("receiver_mail")]
        public string ReceiverMail { get; set; }

        /// <summary>
        /// 接收人手机号码
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 接收人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 接收人固定电话
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 收件人省份
        /// </summary>
        [XmlElement("receiver_province")]
        public string ReceiverProvince { get; set; }

        /// <summary>
        /// 接收人旺旺
        /// </summary>
        [XmlElement("receiver_wangwang")]
        public string ReceiverWangwang { get; set; }

        /// <summary>
        /// 收件人邮编
        /// </summary>
        [XmlElement("receiver_zip_code")]
        public string ReceiverZipCode { get; set; }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 发货日期:  (1)1 为工作日  (2)2 为节假日
        /// </summary>
        [XmlElement("schedule_day")]
        public string ScheduleDay { get; set; }

        /// <summary>
        /// 配送结束时间通常是HH:MM格式
        /// </summary>
        [XmlElement("schedule_end")]
        public string ScheduleEnd { get; set; }

        /// <summary>
        /// 发货速度  ，  101-当日达，  102-次晨达，  103-次日达
        /// </summary>
        [XmlElement("schedule_speed")]
        public long ScheduleSpeed { get; set; }

        /// <summary>
        /// 配送开始时间通常是HH:MM格式
        /// </summary>
        [XmlElement("schedule_start")]
        public string ScheduleStart { get; set; }

        /// <summary>
        /// 发件人地址
        /// </summary>
        [XmlElement("sender_address")]
        public string SenderAddress { get; set; }

        /// <summary>
        /// 发件人所在区
        /// </summary>
        [XmlElement("sender_area")]
        public string SenderArea { get; set; }

        /// <summary>
        /// 发件人城市
        /// </summary>
        [XmlElement("sender_city")]
        public string SenderCity { get; set; }

        /// <summary>
        /// 发件人电子邮箱
        /// </summary>
        [XmlElement("sender_email")]
        public string SenderEmail { get; set; }

        /// <summary>
        /// 发件人移动电话
        /// </summary>
        [XmlElement("sender_mobile")]
        public string SenderMobile { get; set; }

        /// <summary>
        /// 发件人姓名
        /// </summary>
        [XmlElement("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// 发件人联系电话
        /// </summary>
        [XmlElement("sender_phone")]
        public string SenderPhone { get; set; }

        /// <summary>
        /// 发件人所在省份
        /// </summary>
        [XmlElement("sender_province")]
        public string SenderProvince { get; set; }

        /// <summary>
        /// 发件人邮编
        /// </summary>
        [XmlElement("sender_zip_code")]
        public string SenderZipCode { get; set; }

        /// <summary>
        /// cod服务费
        /// </summary>
        [XmlElement("service_fee")]
        public long ServiceFee { get; set; }

        /// <summary>
        /// 物流运输方式：  MAIL-平邮  EXPRESS-快递  EMS-EMS  OTHER-其他
        /// </summary>
        [XmlElement("shipping_type")]
        public string ShippingType { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 发货物流公司编码，STO,YTO,EMS等
        /// </summary>
        [XmlElement("tms_tp_code")]
        public string TmsTpCode { get; set; }

        /// <summary>
        /// 订单总价
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 卖家NICK
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
