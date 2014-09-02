using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TravelItemsSku Data Structure.
    /// </summary>
    [Serializable]
    public class TravelItemsSku : TopObject
    {
        /// <summary>
        /// SKU创建日期 时间格式：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// SKU所属商品数字ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// SKU最后修改日期 时间格式：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 商家设置的外部ID
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 属于这个SKU的商品的价格 取值范围:0-2<<63-1;单位:分。如:20007，表示:200元7分。
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// SKU的销售属性组合字符串（出发日期，出游人群，等等，可通过taobao.travel.itemsprops.get接口获取旅游类目下的销售属性），格式是p1:v1;p2:v2。
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// SKU所对应的销售属性的中文名字串，格式如：pid1:vid1:pid_name1:vid_name1;pid2:vid2:pid_name2:vid_name2……。
        /// </summary>
        [XmlElement("properties_name")]
        public string PropertiesName { get; set; }

        /// <summary>
        /// 属于这个SKU的商品的数量。
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// SKU的ID
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }
    }
}
