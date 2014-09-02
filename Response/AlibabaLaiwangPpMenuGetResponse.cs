using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaLaiwangPpMenuGetResponse.
    /// </summary>
    public class AlibabaLaiwangPpMenuGetResponse : TopResponse
    {
        /// <summary>
        /// 所创建菜单的结构化json串数据.
        /// </summary>
        [XmlElement("menu")]
        public LaiwangPPMenu Menu { get; set; }
    }
}
