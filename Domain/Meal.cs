using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Meal Data Structure.
    /// </summary>
    [Serializable]
    public class Meal : TopObject
    {
        /// <summary>
        /// 搭配套餐商品列表。item_id为商品的id;item_show_name为商品显示名。因最多允许5个商品进行搭配，所以查询最多有5个，以json格式传出。
        /// </summary>
        [XmlElement("item_list")]
        public string ItemList { get; set; }

        /// <summary>
        /// 套餐id。
        /// </summary>
        [XmlElement("meal_id")]
        public long MealId { get; set; }

        /// <summary>
        /// 搭配套餐描述！
        /// </summary>
        [XmlElement("meal_memo")]
        public string MealMemo { get; set; }

        /// <summary>
        /// 搭配套餐名称。
        /// </summary>
        [XmlElement("meal_name")]
        public string MealName { get; set; }

        /// <summary>
        /// 套餐一口价(单位是：分)
        /// </summary>
        [XmlElement("meal_price")]
        public string MealPrice { get; set; }

        /// <summary>
        /// 普通运费模板id。若这个字段为空或0时，运费是卖家负责;若这个字段不为空，说明运费模板存在，运费是买家负责。
        /// </summary>
        [XmlElement("postage_id")]
        public long PostageId { get; set; }

        /// <summary>
        /// 套餐状态。有效：VALID;失效：INVALID(有效套餐为可使用的套餐,无效套餐为套餐中有商品下架或库存为0时)。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
