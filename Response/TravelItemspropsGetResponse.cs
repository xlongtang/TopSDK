using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TravelItemspropsGetResponse.
    /// </summary>
    public class TravelItemspropsGetResponse : TopResponse
    {
        /// <summary>
        /// 旅游商品类目属性结构。
        /// </summary>
        [XmlArray("travel_items_props")]
        [XmlArrayItem("travel_items_prop")]
        public List<TravelItemsProp> TravelItemsProps { get; set; }
    }
}
