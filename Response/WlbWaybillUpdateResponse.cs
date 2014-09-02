using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbWaybillUpdateResponse.
    /// </summary>
    public class WlbWaybillUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新返回
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("waybill_apply_update_info")]
        public List<WaybillApplyUpdateInfo> Results { get; set; }
    }
}
