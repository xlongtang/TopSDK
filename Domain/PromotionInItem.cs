using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// PromotionInItem Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionInItem : TopObject
    {
        /// <summary>
        /// 优惠描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 优惠结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 优惠折后价格
        /// </summary>
        [XmlElement("item_promo_price")]
        public string ItemPromoPrice { get; set; }

        /// <summary>
        /// 优惠展示名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 需要支付附加物，显示为+xxx。如：+20淘金币
        /// </summary>
        [XmlElement("other_need")]
        public string OtherNeed { get; set; }

        /// <summary>
        /// 赠送东西。如：送10商城积分
        /// </summary>
        [XmlElement("other_send")]
        public string OtherSend { get; set; }

        /// <summary>
        /// idValue的值
        /// </summary>
        [XmlElement("promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// sku价格对应的id（保证二者顺序相同）
        /// </summary>
        [XmlArray("sku_id_list")]
        [XmlArrayItem("string")]
        public List<string> SkuIdList { get; set; }

        /// <summary>
        /// sku价格列表
        /// </summary>
        [XmlArray("sku_price_list")]
        [XmlArrayItem("price")]
        public List<string> SkuPriceList { get; set; }

        /// <summary>
        /// 优惠开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
