using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WidgetSkuProps Data Structure.
    /// </summary>
    [Serializable]
    public class WidgetSkuProps : TopObject
    {
        /// <summary>
        /// 商品的属性值别名，对应商品中的property_alias字段中的别名部分
        /// </summary>
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 属性id对应的属性名称，对应类目属性中的属性名称
        /// </summary>
        [XmlElement("key_name")]
        public string KeyName { get; set; }

        /// <summary>
        /// 商品属性图片地址，对应Item中的propImgs，卖家设置了商品属性图片就有此字段，未设置此字段为空
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 淘宝的属性id，对应类目属性中的pid
        /// </summary>
        [XmlElement("prop_key")]
        public long PropKey { get; set; }

        /// <summary>
        /// 淘宝的属性值id，对应类目属性中的vid
        /// </summary>
        [XmlElement("prop_value")]
        public long PropValue { get; set; }

        /// <summary>
        /// 属性值id对应的属性标准名称，对应类目属性中的属性值名称
        /// </summary>
        [XmlElement("value_name")]
        public string ValueName { get; set; }
    }
}
