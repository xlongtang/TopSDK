using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LotteryType Data Structure.
    /// </summary>
    [Serializable]
    public class LotteryType : TopObject
    {
        /// <summary>
        /// 彩种ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 彩种名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
