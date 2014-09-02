using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCatmatchidsDeletedGetResponse.
    /// </summary>
    public class SimbaCatmatchidsDeletedGetResponse : TopResponse
    {
        /// <summary>
        /// 类目出价ID列表
        /// </summary>
        [XmlArray("deleted_catmatch_ids")]
        [XmlArrayItem("number")]
        public List<long> DeletedCatmatchIds { get; set; }
    }
}
