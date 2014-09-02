using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// DealerOrder Data Structure.
    /// </summary>
    [Serializable]
    public class DealerOrder : TopObject
    {
        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_no")]
        public string AlipayNo { get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("applied_time")]
        public string AppliedTime { get; set; }

        /// <summary>
        /// 分销商nick
        /// </summary>
        [XmlElement("applier_nick")]
        public string ApplierNick { get; set; }

        /// <summary>
        /// 分销商最后一次确认/申请/拒绝的时间
        /// </summary>
        [XmlElement("audit_time_applier")]
        public string AuditTimeApplier { get; set; }

        /// <summary>
        /// 供应商最后一次审核通过/修改/驳回的时间
        /// </summary>
        [XmlElement("audit_time_supplier")]
        public string AuditTimeSupplier { get; set; }

        /// <summary>
        /// 关闭原因
        /// </summary>
        [XmlElement("close_reason")]
        public string CloseReason { get; set; }

        /// <summary>
        /// 产品明细
        /// </summary>
        [XmlArray("dealer_order_details")]
        [XmlArrayItem("dealer_order_detail")]
        public List<DealerOrderDetail> DealerOrderDetails { get; set; }

        /// <summary>
        /// 经销采购单编号，API发货使用此字段
        /// </summary>
        [XmlElement("dealer_order_id")]
        public long DealerOrderId { get; set; }

        /// <summary>
        /// 已发货数量
        /// </summary>
        [XmlElement("delivered_quantity_count")]
        public long DeliveredQuantityCount { get; set; }

        /// <summary>
        /// 物流费用(精确到2位小数;单位:元。如:200.07，表示:200元7分 )
        /// </summary>
        [XmlElement("logistics_fee")]
        public string LogisticsFee { get; set; }

        /// <summary>
        /// 物流方式：  SELF_PICKUP（自提）、LOGISTICS（物流发货)
        /// </summary>
        [XmlElement("logistics_type")]
        public string LogisticsType { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// WAIT_FOR_SUPPLIER_AUDIT1：分销商提交申请，待供应商审核；  SUPPLIER_REFUSE：供应商驳回申请，待分销商确认；  WAIT_FOR_APPLIER_AUDIT：供应商修改后，待分销商确认；  WAIT_FOR_SUPPLIER_AUDIT2：分销商拒绝修改，待供应商再审核；  BOTH_AGREE_WAIT_PAY：审核通过下单成功，待分销商付款  WAIT_FOR_SUPPLIER_DELIVER：付款成功，待供应商发货；  WAIT_FOR_APPLIER_STORAGE：供应商发货，待分销商收货；  TRADE_FINISHED：分销商收货，交易成功；  TRADE_CLOSED：经销采购单关闭。
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付方式：  ALIPAY_SURETY（支付宝担保交易）  TRANSFER（线下转账）  PREPAY（预存款）  IMMEDIATELY（即时到账）
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 总采购数量
        /// </summary>
        [XmlElement("quantity_count")]
        public long QuantityCount { get; set; }

        /// <summary>
        /// 收货人信息
        /// </summary>
        [XmlElement("receiver")]
        public Receiver Receiver { get; set; }

        /// <summary>
        /// 分销商拒绝供应商修改的原因
        /// </summary>
        [XmlElement("refuse_reason_applier")]
        public string RefuseReasonApplier { get; set; }

        /// <summary>
        /// 供应商驳回申请的原因
        /// </summary>
        [XmlElement("refuse_reason_supplier")]
        public string RefuseReasonSupplier { get; set; }

        /// <summary>
        /// 供应商备注。  仅供应商可见。
        /// </summary>
        [XmlElement("supplier_memo")]
        public string SupplierMemo { get; set; }

        /// <summary>
        /// 供应商备注旗帜。  1:红色 2:黄色 3:绿色 4:蓝色 5:粉红色。  仅供应商可见。
        /// </summary>
        [XmlElement("supplier_memo_flag")]
        public long SupplierMemoFlag { get; set; }

        /// <summary>
        /// 供应商nick
        /// </summary>
        [XmlElement("supplier_nick")]
        public string SupplierNick { get; set; }

        /// <summary>
        /// 采购总价(精确到2位小数;单位:元。如:200.07，表示:200元7分 )
        /// </summary>
        [XmlElement("total_price")]
        public string TotalPrice { get; set; }
    }
}
