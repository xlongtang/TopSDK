using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// UpdateItemPriceOption Data Structure.
    /// </summary>
    [Serializable]
    public class UpdateItemPriceOption : TopObject
    {
        /// <summary>
        /// 是否忽略涉嫌炒信警告信息
        /// </summary>
        [XmlElement("ignore_fake_credit")]
        public bool IgnoreFakeCredit { get; set; }
    }
}
