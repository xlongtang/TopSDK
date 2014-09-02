using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemJointPropimgResponse.
    /// </summary>
    public class ItemJointPropimgResponse : TopResponse
    {
        /// <summary>
        /// 属性图片对象信息
        /// </summary>
        [XmlElement("prop_img")]
        public PropImg PropImg { get; set; }
    }
}
