using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TipInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TipInfo : TopObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        [XmlElement("info")]
        public string Info { get; set; }

        /// <summary>
        /// 后端商品ID或者商家编码
        /// </summary>
        [XmlElement("sc_item_id")]
        public string ScItemId { get; set; }
    }
}
