using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaNonsearchAdgroupplacesAddResponse.
    /// </summary>
    public class SimbaNonsearchAdgroupplacesAddResponse : TopResponse
    {
        /// <summary>
        /// 推广组定向推广位置列表
        /// </summary>
        [XmlArray("adgroup_place_list")]
        [XmlArrayItem("a_d_group_place")]
        public List<ADGroupPlace> AdgroupPlaceList { get; set; }
    }
}
