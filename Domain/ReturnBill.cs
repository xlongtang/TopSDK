using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ReturnBill Data Structure.
    /// </summary>
    [Serializable]
    public class ReturnBill : TopObject
    {
        /// <summary>
        /// 单据类型
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 物流公司
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 退款创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 退款说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 退款商品信息
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("refund_item")]
        public List<RefundItem> ItemList { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 交易子订单号
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 退货单操作日志
        /// </summary>
        [XmlElement("operation_log")]
        public string OperationLog { get; set; }

        /// <summary>
        /// 申请退款原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退款单编号
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// onsale:售中  aftersale：售后
        /// </summary>
        [XmlElement("refund_phase")]
        public string RefundPhase { get; set; }

        /// <summary>
        /// 退款协议版本
        /// </summary>
        [XmlElement("refund_version")]
        public long RefundVersion { get; set; }

        /// <summary>
        /// 物流运单号
        /// </summary>
        [XmlElement("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// 退款单 状态  wait_buyer_return_goods：卖家同意退货  wait_seller_confirm_goods：买家已退款等待卖家确认  confirm_success：卖家已同意退款  confirm_failed: 卖家已拒绝退款
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 退款单的相关标签信息
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("tag")]
        public List<Tag> TagList { get; set; }

        /// <summary>
        /// 交易主订单号
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }
    }
}
