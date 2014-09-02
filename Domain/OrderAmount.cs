using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// OrderAmount Data Structure.
    /// </summary>
    [Serializable]
    public class OrderAmount : TopObject
    {
        /// <summary>
        /// 卖家手工调整的子订单的优惠金额.格式为:1.01;单位:元;精确到小数点后两位.
        /// </summary>
        [XmlElement("adjust_fee")]
        public string AdjustFee { get; set; }

        /// <summary>
        /// 子订单的系统优惠金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        /// <summary>
        /// 分摊之后的实付金额
        /// </summary>
        [XmlElement("divide_order_fee")]
        public string DivideOrderFee { get; set; }

        /// <summary>
        /// 子交易订单中购买商品的数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 子订单对应的商品数字id
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 子交易订单编号
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 优惠分摊
        /// </summary>
        [XmlElement("part_mjz_discount")]
        public string PartMjzDiscount { get; set; }

        /// <summary>
        /// 子订单实付金额。精确到2位小数，单位:元。如:200.07，表示:200元7分。计算公式如下：payment = price * num + adjust_fee - discount_fee + post_fee(邮费，单笔子订单时子订单实付金额包含邮费，多笔子订单时不包含邮费)；对于退款成功的子订单，由于主订单的优惠分摊金额，会造成该字段可能不为0.00元。建议使用退款前的实付金额减去退款单中的实际退款金额计算。
        /// </summary>
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 商品价格。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 子订单的系统优惠的名称，对应于discount_fee的名称
        /// </summary>
        [XmlElement("promotion_name")]
        public string PromotionName { get; set; }

        /// <summary>
        /// 子订单对应的商品的sku_id
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// SKU的值。如：机身颜色:黑色;手机套餐:官方标配
        /// </summary>
        [XmlElement("sku_properties_name")]
        public string SkuPropertiesName { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
