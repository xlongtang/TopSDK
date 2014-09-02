using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemTemplate Data Structure.
    /// </summary>
    [Serializable]
    public class ItemTemplate : TopObject
    {
        /// <summary>
        /// 用于区分宝贝模板属于内店和外店
        /// </summary>
        [XmlElement("shop_type")]
        public long ShopType { get; set; }

        /// <summary>
        /// 宝贝模板的id
        /// </summary>
        [XmlElement("template_id")]
        public long TemplateId { get; set; }

        /// <summary>
        /// 宝贝详情模板的名称
        /// </summary>
        [XmlElement("template_name")]
        public string TemplateName { get; set; }
    }
}
