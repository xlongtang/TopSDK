using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeikePerformancePutResponse.
    /// </summary>
    public class WeikePerformancePutResponse : TopResponse
    {
        /// <summary>
        /// 返回结果
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
