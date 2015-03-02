using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbWaybillIPrintResponse.
    /// </summary>
    public class WlbWaybillIPrintResponse : TopResponse
    {
        /// <summary>
        /// 错误的面单号
        /// </summary>
        [XmlElement("error_waybill_code")]
        public string ErrorWaybillCode { get; set; }

        /// <summary>
        /// 面单打印信息
        /// </summary>
        [XmlArray("waybill_apply_print_check_infos")]
        [XmlArrayItem("waybill_apply_print_check_info")]
        public List<WaybillApplyPrintCheckInfo> WaybillApplyPrintCheckInfos { get; set; }
    }
}
