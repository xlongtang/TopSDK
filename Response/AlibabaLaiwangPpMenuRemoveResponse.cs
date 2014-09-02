using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaLaiwangPpMenuRemoveResponse.
    /// </summary>
    public class AlibabaLaiwangPpMenuRemoveResponse : TopResponse
    {
        /// <summary>
        /// 删除成功的菜单数量
        /// </summary>
        [XmlElement("deletedcount")]
        public long Deletedcount { get; set; }
    }
}
