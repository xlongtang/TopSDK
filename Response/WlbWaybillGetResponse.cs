using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbWaybillGetResponse.
    /// </summary>
    public class WlbWaybillGetResponse : TopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("waybill_apply_new_info")]
        public List<WaybillApplyNewInfo> Results { get; set; }
    }
}
