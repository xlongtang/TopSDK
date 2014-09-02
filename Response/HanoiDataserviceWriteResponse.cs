using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiDataserviceWriteResponse.
    /// </summary>
    public class HanoiDataserviceWriteResponse : TopResponse
    {
        /// <summary>
        /// 如果为true，表示全部写入成功。  如果为false，表示部分失败，或者全部失败。可以从errorMessage获取写入失败的数据源和属性ID
        /// </summary>
        [XmlElement("model")]
        public bool Model { get; set; }
    }
}
