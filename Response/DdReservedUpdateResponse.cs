using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// DdReservedUpdateResponse.
    /// </summary>
    public class DdReservedUpdateResponse : TopResponse
    {
        /// <summary>
        /// 是否更新成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
