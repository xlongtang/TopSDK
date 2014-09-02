using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TravelItemsAreaNode Data Structure.
    /// </summary>
    [Serializable]
    public class TravelItemsAreaNode : TopObject
    {
        /// <summary>
        /// 该地区下所有下级地区集合(目前地区只有两级，国内：省-市；国际： 国家-城市)。
        /// </summary>
        [XmlArray("sub_prop_values")]
        [XmlArrayItem("travel_items_prop_value")]
        public List<TravelItemsPropValue> SubPropValues { get; set; }

        /// <summary>
        /// 地区属性值。
        /// </summary>
        [XmlElement("travel_items_prop_value")]
        public TravelItemsPropValue TravelItemsPropValue { get; set; }
    }
}
