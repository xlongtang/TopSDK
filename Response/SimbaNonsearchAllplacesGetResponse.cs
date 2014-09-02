using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaNonsearchAllplacesGetResponse.
    /// </summary>
    public class SimbaNonsearchAllplacesGetResponse : TopResponse
    {
        /// <summary>
        /// 定向推广投放位置列表
        /// </summary>
        [XmlArray("place_list")]
        [XmlArrayItem("place")]
        public List<Place> PlaceList { get; set; }
    }
}
