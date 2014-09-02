using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupOnlineitemsvonGetResponse.
    /// </summary>
    public class SimbaAdgroupOnlineitemsvonGetResponse : TopResponse
    {
        /// <summary>
        /// 带分页的淘宝商品
        /// </summary>
        [XmlElement("page_item")]
        public SubwayItemPartition PageItem { get; set; }
    }
}
