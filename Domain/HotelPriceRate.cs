using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// HotelPriceRate Data Structure.
    /// </summary>
    [Serializable]
    public class HotelPriceRate : TopObject
    {
        /// <summary>
        /// 手机购买链接前缀
        /// </summary>
        [XmlElement("h5_buy_url")]
        public string H5BuyUrl { get; set; }

        /// <summary>
        /// 价格和库存信息。  B:date  日期必须为 T---T+28 日内的日期（T为当天），且不能重复  C:price 价格 int类型 取值范围1-99999999 单位为分  D:quota 库存 0为不存在，1为存在
        /// </summary>
        [XmlElement("inventory_price")]
        public string InventoryPrice { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 1, "全额支付" 2, "手续费" 3, "定金" 4, "手续费/间夜" 5, "面付" 6, "后付"
        /// </summary>
        [XmlElement("payment_type")]
        public long PaymentType { get; set; }

        /// <summary>
        /// pc购买链接前缀
        /// </summary>
        [XmlElement("pc_buy_url")]
        public string PcBuyUrl { get; set; }

        /// <summary>
        /// 酒店RPID
        /// </summary>
        [XmlElement("rpid")]
        public long Rpid { get; set; }
    }
}
