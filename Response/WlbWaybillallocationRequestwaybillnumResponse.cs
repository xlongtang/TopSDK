using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbWaybillallocationRequestwaybillnumResponse.
    /// </summary>
    public class WlbWaybillallocationRequestwaybillnumResponse : TopResponse
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 电子面单号码
        /// </summary>
        [XmlArray("tms_waybill_list")]
        [XmlArrayItem("string")]
        public List<string> TmsWaybillList { get; set; }
    }
}
