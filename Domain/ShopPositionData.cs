using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ShopPositionData Data Structure.
    /// </summary>
    [Serializable]
    public class ShopPositionData : TopObject
    {
        /// <summary>
        /// 店铺的地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 卖家店铺所在的城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 淘宝商品的数字id，对应了商品线的一个商品对象标识
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 卖家店铺的手机联系号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 卖家的账户数字id
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 标识了一个唯一的地址位置对象，具有独立的坐标和交通信息
        /// </summary>
        [XmlElement("shop_position_id")]
        public long ShopPositionId { get; set; }

        /// <summary>
        /// 描述店铺的名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 店铺的一些交通提示信息
        /// </summary>
        [XmlElement("traffic")]
        public string Traffic { get; set; }

        /// <summary>
        /// 店铺所在的经度，放大100000倍
        /// </summary>
        [XmlElement("x")]
        public long X { get; set; }

        /// <summary>
        /// 店铺所在的纬度，放大100000倍
        /// </summary>
        [XmlElement("y")]
        public long Y { get; set; }
    }
}
