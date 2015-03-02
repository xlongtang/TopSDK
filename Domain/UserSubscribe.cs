using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// UserSubscribe Data Structure.
    /// </summary>
    [Serializable]
    public class UserSubscribe : TopObject
    {
        /// <summary>
        /// 订购结束时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 订购开始时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 订购状况。应用订购者：subscribeUser;尚未订购：unsubscribeUser；非法用户：invalidateUser
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
