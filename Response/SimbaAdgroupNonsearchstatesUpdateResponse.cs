using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupNonsearchstatesUpdateResponse.
    /// </summary>
    public class SimbaAdgroupNonsearchstatesUpdateResponse : TopResponse
    {
        /// <summary>
        /// 推广组列表
        /// </summary>
        [XmlArray("adgroup_list")]
        [XmlArrayItem("a_d_group")]
        public List<ADGroup> AdgroupList { get; set; }
    }
}
