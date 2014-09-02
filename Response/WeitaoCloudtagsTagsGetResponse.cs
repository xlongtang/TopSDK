using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoCloudtagsTagsGetResponse.
    /// </summary>
    public class WeitaoCloudtagsTagsGetResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 具体的标签数据
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("clouds_tag")]
        public List<CloudsTag> TagList { get; set; }
    }
}
