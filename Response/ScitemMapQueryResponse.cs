using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ScitemMapQueryResponse.
    /// </summary>
    public class ScitemMapQueryResponse : TopResponse
    {
        /// <summary>
        /// 后端商品映射列表
        /// </summary>
        [XmlArray("sc_item_maps")]
        [XmlArrayItem("sc_item_map")]
        public List<ScItemMap> ScItemMaps { get; set; }
    }
}
