using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoCloudtagsGroupGetbyidResponse.
    /// </summary>
    public class WeitaoCloudtagsGroupGetbyidResponse : TopResponse
    {
        /// <summary>
        /// 分组列表信息
        /// </summary>
        [XmlArray("group_list")]
        [XmlArrayItem("cloud_group")]
        public List<CloudGroup> GroupList { get; set; }
    }
}
