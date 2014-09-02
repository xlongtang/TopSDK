using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ServiceOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ServiceOrder : TopObject
    {
        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 服务所属的交易订单号。如果服务为一年包换，则item_oid这笔订单享受改服务的保护
        /// </summary>
        [XmlElement("item_oid")]
        public long ItemOid { get; set; }

        /// <summary>
        /// 购买数量，取值范围为大于0的整数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 虚拟服务子订单订单号
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 子订单实付金额。精确到2位小数，单位:元。如:200.07，表示:200元7分。
        /// </summary>
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 服务图片地址
        /// </summary>
        [XmlElement("pic_path")]
        public string PicPath { get; set; }

        /// <summary>
        /// 服务价格，精确到小数点后两位：单位:元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 最近退款的id
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 服务详情的URL地址
        /// </summary>
        [XmlElement("service_detail_url")]
        public string ServiceDetailUrl { get; set; }

        /// <summary>
        /// 服务数字id
        /// </summary>
        [XmlElement("service_id")]
        public long ServiceId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 服务子订单总费用
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }
    }
}
