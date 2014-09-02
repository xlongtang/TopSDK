using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbItemConsignmentCreateResponse.
    /// </summary>
    public class WlbItemConsignmentCreateResponse : TopResponse
    {
        /// <summary>
        /// 代销关系唯一标识
        /// </summary>
        [XmlElement("consignment_id")]
        public long ConsignmentId { get; set; }
    }
}
