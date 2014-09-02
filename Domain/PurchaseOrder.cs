using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// PurchaseOrder Data Structure.
    /// </summary>
    [Serializable]
    public class PurchaseOrder : TopObject
    {
        /// <summary>
        /// 支付宝交易号。
        /// </summary>
        [XmlElement("alipay_no")]
        public string AlipayNo { get; set; }

        /// <summary>
        /// 买家nick，供应商查询不会返回买家昵称，分销商查询才会返回。
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家支付给分销商的总金额。注意买家购买的商品可能不是全部来自同一供货商，请同时参考子单上的相关金额。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("buyer_payment")]
        public string BuyerPayment { get; set; }

        /// <summary>
        /// 加密后的买家淘宝ID，长度为32位
        /// </summary>
        [XmlElement("buyer_taobao_id")]
        public string BuyerTaobaoId { get; set; }

        /// <summary>
        /// 物流发货时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("consign_time")]
        public string ConsignTime { get; set; }

        /// <summary>
        /// 采购单创建时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 分销商来源网站（taobao）。
        /// </summary>
        [XmlElement("distributor_from")]
        public string DistributorFrom { get; set; }

        /// <summary>
        /// 分销商实付金额。(精确到2位小数;单位:元。如:200.07，表示:200元7分 )
        /// </summary>
        [XmlElement("distributor_payment")]
        public string DistributorPayment { get; set; }

        /// <summary>
        /// 分销商在来源网站的帐号名。
        /// </summary>
        [XmlElement("distributor_username")]
        public string DistributorUsername { get; set; }

        /// <summary>
        /// 交易结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 主订单属性信息，key-value形式：  orderNovice ：订单发票抬头；  orderNoviceContent ：代表发票明细
        /// </summary>
        [XmlArray("features")]
        [XmlArrayItem("feature")]
        public List<Feature> Features { get; set; }

        /// <summary>
        /// 分销流水号，分销平台产生的主键
        /// </summary>
        [XmlElement("fenxiao_id")]
        public long FenxiaoId { get; set; }

        /// <summary>
        /// 供应商交易ID 非采购单ID，如果改发货状态 是需要该ID，ID在用户未付款前为0，付款后有具体值（发货时使用该ID）
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 自定义key
        /// </summary>
        [XmlArray("isv_custom_key")]
        [XmlArrayItem("string")]
        public List<string> IsvCustomKey { get; set; }

        /// <summary>
        /// 自定义值
        /// </summary>
        [XmlArray("isv_custom_value")]
        [XmlArrayItem("string")]
        public List<string> IsvCustomValue { get; set; }

        /// <summary>
        /// 物流公司
        /// </summary>
        [XmlElement("logistics_company_name")]
        public string LogisticsCompanyName { get; set; }

        /// <summary>
        /// 运单号
        /// </summary>
        [XmlElement("logistics_id")]
        public string LogisticsId { get; set; }

        /// <summary>
        /// 采购单留言。（代销模式下信息包括买家留言和分销商留言）
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 交易修改时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 采购单留言列表
        /// </summary>
        [XmlArray("order_messages")]
        [XmlArrayItem("order_message")]
        public List<OrderMessage> OrderMessages { get; set; }

        /// <summary>
        /// 付款时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 支付方式：ALIPAY_SURETY（支付宝担保交易）、ALIPAY_CHAIN（分账交易）、TRANSFER（线下转账）、PREPAY（预存款）、IMMEDIATELY（即时到账）、CASHGOODS（先款后货）
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 采购单邮费。(精确到2位小数;单位:元。如:200.07，表示:200元7分 )
        /// </summary>
        [XmlElement("post_fee")]
        public string PostFee { get; set; }

        /// <summary>
        /// 买家详细的信息。
        /// </summary>
        [XmlElement("receiver")]
        public Receiver Receiver { get; set; }

        /// <summary>
        /// 配送方式，FAST(快速)、EMS、ORDINARY(平邮)、SELLER(卖家包邮)
        /// </summary>
        [XmlElement("shipping")]
        public string Shipping { get; set; }

        /// <summary>
        /// 订单快照URL
        /// </summary>
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }

        /// <summary>
        /// 采购单交易状态。可选值：<br> WAIT_BUYER_PAY(等待付款)<br> WAIT_SELLER_SEND_GOODS(已付款，待发货）<br> WAIT_BUYER_CONFIRM_GOODS(已付款，已发货)<br> TRADE_FINISHED(交易成功)<br> TRADE_CLOSED(交易关闭)<br> WAIT_BUYER_CONFIRM_GOODS_ACOUNTED(已付款（已分账），已发货。只对代销分账支持)<br> PAY_ACOUNTED_GOODS_CONFIRM （已分账发货成功）<br> PAY_WAIT_ACOUNT_GOODS_CONFIRM（已付款，确认收货）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 子订单的详细信息列表。
        /// </summary>
        [XmlArray("sub_purchase_orders")]
        [XmlArrayItem("sub_purchase_order")]
        public List<SubPurchaseOrder> SubPurchaseOrders { get; set; }

        /// <summary>
        /// 返回供应商备注旗帜  vlaue在1-5之间。非1-5之间，都采用1作为默认。 1:红色 2:黄色 3:绿色 4:蓝色 5:粉红色
        /// </summary>
        [XmlElement("supplier_flag")]
        public long SupplierFlag { get; set; }

        /// <summary>
        /// 供应商来源网站, values: taobao, alibaba
        /// </summary>
        [XmlElement("supplier_from")]
        public string SupplierFrom { get; set; }

        /// <summary>
        /// 供应商备注
        /// </summary>
        [XmlElement("supplier_memo")]
        public string SupplierMemo { get; set; }

        /// <summary>
        /// 供应商在来源网站的帐号名。
        /// </summary>
        [XmlElement("supplier_username")]
        public string SupplierUsername { get; set; }

        /// <summary>
        /// 主订单ID （经销不显示）
        /// </summary>
        [XmlElement("tc_order_id")]
        public long TcOrderId { get; set; }

        /// <summary>
        /// 采购单总额（不含邮费,精确到2位小数;单位:元。如:200.07，表示:200元7分 )
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }

        /// <summary>
        /// 分销方式：AGENT（代销）、DEALER（经销）
        /// </summary>
        [XmlElement("trade_type")]
        public string TradeType { get; set; }
    }
}
