using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiAddressGetResponse.
    /// </summary>
    public class WaimaiAddressGetResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
