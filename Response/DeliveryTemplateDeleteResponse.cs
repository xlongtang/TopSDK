using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// DeliveryTemplateDeleteResponse.
    /// </summary>
    public class DeliveryTemplateDeleteResponse : TopResponse
    {
        /// <summary>
        /// 表示删除成功还是失败
        /// </summary>
        [XmlElement("complete")]
        public bool Complete { get; set; }
    }
}
