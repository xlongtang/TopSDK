using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JuItemidsGetResponse.
    /// </summary>
    public class JuItemidsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回的商品ID列表
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("number")]
        public List<long> ItemIds { get; set; }
    }
}
