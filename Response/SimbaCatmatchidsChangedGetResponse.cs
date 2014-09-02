using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCatmatchidsChangedGetResponse.
    /// </summary>
    public class SimbaCatmatchidsChangedGetResponse : TopResponse
    {
        /// <summary>
        /// 类目出价ID列表
        /// </summary>
        [XmlArray("changed_catmatch_ids")]
        [XmlArrayItem("number")]
        public List<long> ChangedCatmatchIds { get; set; }
    }
}
