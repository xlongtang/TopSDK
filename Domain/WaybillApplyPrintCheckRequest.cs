using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillApplyPrintCheckRequest Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillApplyPrintCheckRequest : TopObject
    {
        /// <summary>
        /// TOP平台请求的ISV APPKEY
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 物流服务商Code
        /// </summary>
        [XmlElement("cp_code")]
        public string CpCode { get; set; }

        /// <summary>
        /// 打印面单详细信息
        /// </summary>
        [XmlArray("print_check_info_cols")]
        [XmlArrayItem("print_check_info")]
        public List<PrintCheckInfo> PrintCheckInfoCols { get; set; }

        /// <summary>
        /// 申请者编码
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }
    }
}
