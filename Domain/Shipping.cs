using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Shipping Data Structure.
    /// </summary>
    [Serializable]
    public class Shipping : TopObject
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 运单创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 预约取货结束时间
        /// </summary>
        [XmlElement("delivery_end")]
        public string DeliveryEnd { get; set; }

        /// <summary>
        /// 预约取货开始时间
        /// </summary>
        [XmlElement("delivery_start")]
        public string DeliveryStart { get; set; }

        /// <summary>
        /// 谁承担运费.可选值:buyer(买家承担),seller(卖家承担运费).
        /// </summary>
        [XmlElement("freight_payer")]
        public string FreightPayer { get; set; }

        /// <summary>
        /// 标示为是否快捷COD订单
        /// </summary>
        [XmlElement("is_quick_cod_order")]
        public bool IsQuickCodOrder { get; set; }

        /// <summary>
        /// 表明是否是拆单，默认值0，1表示拆单
        /// </summary>
        [XmlElement("is_spilt")]
        public long IsSpilt { get; set; }

        /// <summary>
        /// 返回发货是否成功。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 货物名称
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 收件人地址信息(在传输请求参数Fields字段时，必须使用“receiver_location”才能返回此字段)
        /// </summary>
        [XmlElement("location")]
        public Location Location { get; set; }

        /// <summary>
        /// 运单修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 物流订单编号
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 运单号.具体一个物流公司的运单号码.
        /// </summary>
        [XmlElement("out_sid")]
        public string OutSid { get; set; }

        /// <summary>
        /// 收件人手机号码
        /// </summary>
        [XmlElement("receiver_mobile")]
        public string ReceiverMobile { get; set; }

        /// <summary>
        /// 收件人姓名
        /// </summary>
        [XmlElement("receiver_name")]
        public string ReceiverName { get; set; }

        /// <summary>
        /// 收件人电话
        /// </summary>
        [XmlElement("receiver_phone")]
        public string ReceiverPhone { get; set; }

        /// <summary>
        /// 卖家是否确认发货.可选值:yes(是),no(否).
        /// </summary>
        [XmlElement("seller_confirm")]
        public string SellerConfirm { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 物流订单状态,可选值:  CREATED(订单已创建)   RECREATED(订单重新创建)   CANCELLED(订单已取消)   CLOSED(订单关闭)   SENDING(等候发送给物流公司)   ACCEPTING(已发送给物流公司,等待接单)   ACCEPTED(物流公司已接单)   REJECTED(物流公司不接单)   PICK_UP(物流公司揽收成功)   PICK_UP_FAILED(物流公司揽收失败)   LOST(物流公司丢单)   REJECTED_BY_RECEIVER(对方拒签)   ACCEPTED_BY_RECEIVER(发货方式在线下单：对方已签收；自己联系：卖家已发货)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 拆单子订单列表，对应的数据是：该物流订单下的全部子订单
        /// </summary>
        [XmlArray("sub_tids")]
        [XmlArrayItem("number")]
        public List<long> SubTids { get; set; }

        /// <summary>
        /// 交易ID
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }

        /// <summary>
        /// 物流方式.可选值:free(卖家包邮),post(平邮),express(快递),ems(EMS).
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
