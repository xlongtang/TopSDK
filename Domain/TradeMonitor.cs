using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TradeMonitor Data Structure.
    /// </summary>
    [Serializable]
    public class TradeMonitor : TopObject
    {
        /// <summary>
        /// 地区
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 交易订单的商品购买数量
        /// </summary>
        [XmlElement("buy_amount")]
        public long BuyAmount { get; set; }

        /// <summary>
        /// 收货人姓名
        /// </summary>
        [XmlElement("buyer_full_name")]
        public string BuyerFullName { get; set; }

        /// <summary>
        /// 买家的淘宝账号昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 经销商的淘宝账号昵称
        /// </summary>
        [XmlElement("distributor_nick")]
        public string DistributorNick { get; set; }

        /// <summary>
        /// 交易订单的商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 交易订单的商品的商家编码
        /// </summary>
        [XmlElement("item_number")]
        public string ItemNumber { get; set; }

        /// <summary>
        /// 交易订单的商品价格
        /// </summary>
        [XmlElement("item_price")]
        public long ItemPrice { get; set; }

        /// <summary>
        /// 交易订单的商品的sku名称
        /// </summary>
        [XmlElement("item_sku_name")]
        public string ItemSkuName { get; set; }

        /// <summary>
        /// 交易订单的商品的sku商家编码
        /// </summary>
        [XmlElement("item_sku_number")]
        public string ItemSkuNumber { get; set; }

        /// <summary>
        /// 交易订单的商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 交易订单的商品总价格（单价×数量+改价+优惠）
        /// </summary>
        [XmlElement("item_total_price")]
        public long ItemTotalPrice { get; set; }

        /// <summary>
        /// 交易订单的付款时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 供应商的产品id
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 供应商的产品的商家编码
        /// </summary>
        [XmlElement("product_number")]
        public string ProductNumber { get; set; }

        /// <summary>
        /// 供应商的产品的sku商家编码
        /// </summary>
        [XmlElement("product_sku_number")]
        public string ProductSkuNumber { get; set; }

        /// <summary>
        /// 供应商的产品标题
        /// </summary>
        [XmlElement("product_title")]
        public string ProductTitle { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [XmlElement("provence")]
        public string Provence { get; set; }

        /// <summary>
        /// 交易订单的商品最高零售价
        /// </summary>
        [XmlElement("retail_price_high")]
        public long RetailPriceHigh { get; set; }

        /// <summary>
        /// 交易订单的商品最低零售价
        /// </summary>
        [XmlElement("retail_price_low")]
        public long RetailPriceLow { get; set; }

        /// <summary>
        /// 收货人地址
        /// </summary>
        [XmlElement("shipping_address")]
        public string ShippingAddress { get; set; }

        /// <summary>
        /// 交易订单的状态：  WAIT_SELLER_SEND_GOODS(已付款，待发货）<br>WAIT_BUYER_CONFIRM_GOODS(已付款，已发货)<br>TRADE_FINISHED(交易成功)  TRADE_CLOSED(交易关闭)<br>TRADE_REFUNDING（退款中）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易订单的子订单号
        /// </summary>
        [XmlElement("sub_tc_order_id")]
        public long SubTcOrderId { get; set; }

        /// <summary>
        /// 供应商的淘宝账号昵称
        /// </summary>
        [XmlElement("supplier_nick")]
        public string SupplierNick { get; set; }

        /// <summary>
        /// 商品的卖出金额调整，金额增加时为正数，金额减少时为负数，单位是分，不带小数
        /// </summary>
        [XmlElement("tc_adjust_fee")]
        public long TcAdjustFee { get; set; }

        /// <summary>
        /// 优惠金额，始终为正数，单位是分，不带小数
        /// </summary>
        [XmlElement("tc_discount_fee")]
        public long TcDiscountFee { get; set; }

        /// <summary>
        /// 交易订单号
        /// </summary>
        [XmlElement("tc_order_id")]
        public long TcOrderId { get; set; }

        /// <summary>
        /// 商品优惠类型：聚划算、秒杀或其他
        /// </summary>
        [XmlElement("tc_preferential_type")]
        public string TcPreferentialType { get; set; }

        /// <summary>
        /// 主键id
        /// </summary>
        [XmlElement("trade_monitor_id")]
        public long TradeMonitorId { get; set; }
    }
}
