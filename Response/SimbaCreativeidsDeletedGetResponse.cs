using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCreativeidsDeletedGetResponse.
    /// </summary>
    public class SimbaCreativeidsDeletedGetResponse : TopResponse
    {
        /// <summary>
        /// 创意ID列表
        /// </summary>
        [XmlArray("deleted_creative_ids")]
        [XmlArrayItem("number")]
        public List<long> DeletedCreativeIds { get; set; }
    }
}
