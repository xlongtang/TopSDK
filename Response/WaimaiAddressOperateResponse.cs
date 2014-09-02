using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiAddressOperateResponse.
    /// </summary>
    public class WaimaiAddressOperateResponse : TopResponse
    {
        /// <summary>
        /// 是一个JSON
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
