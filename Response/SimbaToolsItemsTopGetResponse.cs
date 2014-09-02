using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaToolsItemsTopGetResponse.
    /// </summary>
    public class SimbaToolsItemsTopGetResponse : TopResponse
    {
        /// <summary>
        /// 推广组信息列表
        /// </summary>
        [XmlArray("rankeditems")]
        [XmlArrayItem("ranked_item")]
        public List<RankedItem> Rankeditems { get; set; }
    }
}
