using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaybillApplyPrintCheckInfo Data Structure.
    /// </summary>
    [Serializable]
    public class WaybillApplyPrintCheckInfo : TopObject
    {
        /// <summary>
        /// 打印提示信息编码
        /// </summary>
        [XmlElement("notice_code")]
        public string NoticeCode { get; set; }

        /// <summary>
        /// 打印提示信息
        /// </summary>
        [XmlElement("notice_message")]
        public string NoticeMessage { get; set; }

        /// <summary>
        /// 打印次数
        /// </summary>
        [XmlElement("print_quantity")]
        public long PrintQuantity { get; set; }

        /// <summary>
        /// 电子面单号
        /// </summary>
        [XmlElement("waybill_code")]
        public string WaybillCode { get; set; }
    }
}
