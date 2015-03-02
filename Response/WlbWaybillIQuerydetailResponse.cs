using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbWaybillIQuerydetailResponse.
    /// </summary>
    public class WlbWaybillIQuerydetailResponse : TopResponse
    {
        /// <summary>
        /// 面单查询错误编码
        /// </summary>
        [XmlArray("error_codes")]
        [XmlArrayItem("string")]
        public List<string> ErrorCodes { get; set; }

        /// <summary>
        /// 不存在的面单号
        /// </summary>
        [XmlArray("inexistent_waybill_codes")]
        [XmlArrayItem("string")]
        public List<string> InexistentWaybillCodes { get; set; }

        /// <summary>
        /// 查询是否成功
        /// </summary>
        [XmlElement("query_success")]
        public bool QuerySuccess { get; set; }

        /// <summary>
        /// 面单详情
        /// </summary>
        [XmlArray("waybill_details")]
        [XmlArrayItem("waybill_detail_query_info")]
        public List<WaybillDetailQueryInfo> WaybillDetails { get; set; }
    }
}
