using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbProcessStatus Data Structure.
    /// </summary>
    [Serializable]
    public class WlbProcessStatus : TopObject
    {
        /// <summary>
        /// 状态内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [XmlElement("operate_time")]
        public string OperateTime { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [XmlElement("operater")]
        public string Operater { get; set; }

        /// <summary>
        /// 物流宝订单编码
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单操作状态：WMS_ACCEPT;WMS_PRINT;WMS_PICK;WMS_CHECK;WMS_PACKAGE;WMS_CONSIGN;WMS_CANCEL;WMS_UNKNOWN;WMS_CONFIRMED  TMS_ACCEPT;TMS_STATION_IN;TMS_STATION_OUT;TMS_SIGN;TMS_REJECT;TMS_CANCEL;TMS_UNKNOW;SYS_UNKNOWN
        /// </summary>
        [XmlElement("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// 仓库合作公司编码
        /// </summary>
        [XmlElement("store_tp_code")]
        public string StoreTpCode { get; set; }

        /// <summary>
        /// tms合作公司订单编码
        /// </summary>
        [XmlElement("tms_order_code")]
        public string TmsOrderCode { get; set; }

        /// <summary>
        /// tms合作公司编码
        /// </summary>
        [XmlElement("tms_tp_code")]
        public string TmsTpCode { get; set; }
    }
}
