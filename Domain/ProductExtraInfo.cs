using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ProductExtraInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ProductExtraInfo : TopObject
    {
        /// <summary>
        /// 产品扩展信息键
        /// </summary>
        [XmlElement("field_key")]
        public string FieldKey { get; set; }

        /// <summary>
        /// 产品扩展信息名称
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 产品扩展信息简介
        /// </summary>
        [XmlElement("field_value")]
        public string FieldValue { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [XmlElement("product_id")]
        public long ProductId { get; set; }
    }
}
