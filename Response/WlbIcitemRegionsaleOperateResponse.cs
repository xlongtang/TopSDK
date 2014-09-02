using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbIcitemRegionsaleOperateResponse.
    /// </summary>
    public class WlbIcitemRegionsaleOperateResponse : TopResponse
    {
        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }
    }
}
