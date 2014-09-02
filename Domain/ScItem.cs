using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ScItem Data Structure.
    /// </summary>
    [Serializable]
    public class ScItem : TopObject
    {
        /// <summary>
        /// 条形码
        /// </summary>
        [XmlElement("bar_code")]
        public string BarCode { get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public long BrandId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 高 单位：mm
        /// </summary>
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 1表示区域销售，0或是空是非区域销售
        /// </summary>
        [XmlElement("is_area_sale")]
        public long IsAreaSale { get; set; }

        /// <summary>
        /// 贵重品:false:不是 true：是
        /// </summary>
        [XmlElement("is_costly")]
        public bool IsCostly { get; set; }

        /// <summary>
        /// 是否危险 false：不是  true：是
        /// </summary>
        [XmlElement("is_dangerous")]
        public bool IsDangerous { get; set; }

        /// <summary>
        /// 是否易碎 false ：不是  true：是
        /// </summary>
        [XmlElement("is_friable")]
        public bool IsFriable { get; set; }

        /// <summary>
        /// 是否保质期：false:不是 true：是
        /// </summary>
        [XmlElement("is_warranty")]
        public bool IsWarranty { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 1.普通供应链商品 2.供应链组合主商品
        /// </summary>
        [XmlElement("item_type")]
        public long ItemType { get; set; }

        /// <summary>
        /// 长度 单位：mm
        /// </summary>
        [XmlElement("length")]
        public long Length { get; set; }

        /// <summary>
        /// LIQUID:液体，1：粉体，SOLID：固体
        /// </summary>
        [XmlElement("matter_status")]
        public string MatterStatus { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        [XmlElement("outer_code")]
        public string OuterCode { get; set; }

        /// <summary>
        /// 价格：分（吊牌价）
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 商品属性格式是  p1:v1,p2:v2,p3:v3
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 体积：立方厘米
        /// </summary>
        [XmlElement("volume")]
        public long Volume { get; set; }

        /// <summary>
        /// 重量.单位：克
        /// </summary>
        [XmlElement("weight")]
        public long Weight { get; set; }

        /// <summary>
        /// 宽 单位：mm
        /// </summary>
        [XmlElement("width")]
        public long Width { get; set; }

        /// <summary>
        /// 仓储商编码，可以支持多个，格式wmsname:code
        /// </summary>
        [XmlElement("wms_code")]
        public string WmsCode { get; set; }
    }
}
