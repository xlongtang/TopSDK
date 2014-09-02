using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// AccountStat Data Structure.
    /// </summary>
    [Serializable]
    public class AccountStat : TopObject
    {
        /// <summary>
        /// 登录状态。0：离线；1：在线
        /// </summary>
        [XmlElement("login_status")]
        public long LoginStatus { get; set; }

        /// <summary>
        /// 服务状态。0：挂起；1：服务
        /// </summary>
        [XmlElement("onservice_status")]
        public long OnserviceStatus { get; set; }

        /// <summary>
        /// 操作时间。格式：YYYY-mm-dd HH:MM:SS
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }
    }
}
