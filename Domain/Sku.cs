using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Sku Data Structure.
    /// </summary>
    [Serializable]
    public class Sku : TopObject
    {
        /// <summary>
        /// 基础色数据
        /// </summary>
        [XmlElement("change_prop")]
        public string ChangeProp { get; set; }

        /// <summary>
        /// sku创建日期 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// sku所属商品id(注意：iid近期即将废弃，请用num_iid参数)
        /// </summary>
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// sku最后修改日期 时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// sku所属商品数字id
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 商家设置的外部id。天猫和集市的卖家，需要登录才能获取到自己的商家编码，不能获取到他人的商家编码。
        /// </summary>
        [XmlElement("outer_id")]
        public string OuterId { get; set; }

        /// <summary>
        /// 属于这个sku的商品的价格 取值范围:0-100000000;精确到2位小数;单位:元。如:200.07，表示:200元7分。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// sku的销售属性组合字符串（颜色，大小，等等，可通过类目API获取某类目下的销售属性）,格式是p1:v1;p2:v2
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// sku所对应的销售属性的中文名字串，格式如：pid1:vid1:pid_name1:vid_name1;pid2:vid2:pid_name2:vid_name2……
        /// </summary>
        [XmlElement("properties_name")]
        public string PropertiesName { get; set; }

        /// <summary>
        /// 属于这个sku的商品的数量，
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// sku级别发货时间
        /// </summary>
        [XmlElement("sku_delivery_time")]
        public string SkuDeliveryTime { get; set; }

        /// <summary>
        /// sku的id
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// 表示SKu上的产品规格信息
        /// </summary>
        [XmlElement("sku_spec_id")]
        public long SkuSpecId { get; set; }

        /// <summary>
        /// sku状态。 normal:正常 ；delete:删除
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品在付款减库存的状态下，该sku上未付款的订单数量
        /// </summary>
        [XmlElement("with_hold_quantity")]
        public long WithHoldQuantity { get; set; }
    }
}
