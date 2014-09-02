using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCreativesRecordGetResponse.
    /// </summary>
    public class SimbaCreativesRecordGetResponse : TopResponse
    {
        /// <summary>
        /// 创意修改对象列表
        /// </summary>
        [XmlArray("creativerecords")]
        [XmlArrayItem("creative_record")]
        public List<CreativeRecord> Creativerecords { get; set; }
    }
}
