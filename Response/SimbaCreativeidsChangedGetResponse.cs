using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCreativeidsChangedGetResponse.
    /// </summary>
    public class SimbaCreativeidsChangedGetResponse : TopResponse
    {
        /// <summary>
        /// 创意ID列表
        /// </summary>
        [XmlArray("changed_creative_ids")]
        [XmlArrayItem("number")]
        public List<long> ChangedCreativeIds { get; set; }
    }
}
