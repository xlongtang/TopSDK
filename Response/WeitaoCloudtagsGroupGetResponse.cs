using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoCloudtagsGroupGetResponse.
    /// </summary>
    public class WeitaoCloudtagsGroupGetResponse : TopResponse
    {
        /// <summary>
        /// 分组列表信息
        /// </summary>
        [XmlArray("group_list")]
        [XmlArrayItem("cloud_group")]
        public List<CloudGroup> GroupList { get; set; }
    }
}
