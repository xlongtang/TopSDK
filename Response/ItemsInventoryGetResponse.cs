using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemsInventoryGetResponse.
    /// </summary>
    public class ItemsInventoryGetResponse : TopResponse
    {
        /// <summary>
        /// 搜索到底商品列表，具体字段根据设定的fields决定，不包括desc,stuff_status字段
        /// </summary>
        [XmlArray("items")]
        [XmlArrayItem("item")]
        public List<Item> Items { get; set; }

        /// <summary>
        /// 搜索到符合条件的结果总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
