using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentGetallclassResponse.
    /// </summary>
    public class SpContentGetallclassResponse : TopResponse
    {
        /// <summary>
        /// 返回Json格式的分类名称列表
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
