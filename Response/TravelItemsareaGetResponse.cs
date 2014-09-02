using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TravelItemsareaGetResponse.
    /// </summary>
    public class TravelItemsareaGetResponse : TopResponse
    {
        /// <summary>
        /// 旅游度假商品地区（目的地）级联结构。
        /// </summary>
        [XmlArray("travel_items_area_nodes")]
        [XmlArrayItem("travel_items_area_node")]
        public List<TravelItemsAreaNode> TravelItemsAreaNodes { get; set; }
    }
}
