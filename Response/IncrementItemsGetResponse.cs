using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// IncrementItemsGetResponse.
    /// </summary>
    public class IncrementItemsGetResponse : TopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("notify_items")]
        [XmlArrayItem("notify_item")]
        public List<NotifyItem> NotifyItems { get; set; }

        /// <summary>
        /// 搜索到符合条件的结果总数。
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
