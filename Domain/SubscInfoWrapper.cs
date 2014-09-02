using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubscInfoWrapper Data Structure.
    /// </summary>
    [Serializable]
    public class SubscInfoWrapper : TopObject
    {
        /// <summary>
        /// 需求订购信息
        /// </summary>
        [XmlArray("subsc_info_list")]
        [XmlArrayItem("subsc_info")]
        public List<SubscInfo> SubscInfoList { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
