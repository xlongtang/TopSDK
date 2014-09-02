using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ArticleBizOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ArticleBizOrder : TopObject
    {
        /// <summary>
        /// 应用收费代码，从合作伙伴后台（my.open.taobao.com）-收费管理-收费项目列表 能够获得该应用的收费代码
        /// </summary>
        [XmlElement("article_code")]
        public string ArticleCode { get; set; }

        /// <summary>
        /// 商品模型名称
        /// </summary>
        [XmlElement("article_item_name")]
        public string ArticleItemName { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [XmlElement("article_name")]
        public string ArticleName { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public long BizOrderId { get; set; }

        /// <summary>
        /// 订单类型，1=新订 2=续订 3=升级 4=后台赠送 5=后台自动续订 6=订单审核后生成订购关系（暂时用不到）
        /// </summary>
        [XmlElement("biz_type")]
        public long BizType { get; set; }

        /// <summary>
        /// 订单创建时间（订购时间）
        /// </summary>
        [XmlElement("create")]
        public string Create { get; set; }

        /// <summary>
        /// 原价（单位为分）
        /// </summary>
        [XmlElement("fee")]
        public string Fee { get; set; }

        /// <summary>
        /// 收费项目代码，从合作伙伴后台（my.open.taobao.com）-收费管理-收费项目列表 能够获得收费项目代码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 收费项目名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 淘宝会员名
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 订购周期  1表示年 ，2表示月，3表示天。
        /// </summary>
        [XmlElement("order_cycle")]
        public string OrderCycle { get; set; }

        /// <summary>
        /// 订购周期结束时间
        /// </summary>
        [XmlElement("order_cycle_end")]
        public string OrderCycleEnd { get; set; }

        /// <summary>
        /// 订购周期开始时间
        /// </summary>
        [XmlElement("order_cycle_start")]
        public string OrderCycleStart { get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 优惠（单位为分）
        /// </summary>
        [XmlElement("prom_fee")]
        public string PromFee { get; set; }

        /// <summary>
        /// 退款（单位为分；升级时，系统会将升级前老版本按照剩余订购天数退还剩余金额）
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 实付（单位为分）
        /// </summary>
        [XmlElement("total_pay_fee")]
        public string TotalPayFee { get; set; }
    }
}
