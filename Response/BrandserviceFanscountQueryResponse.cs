using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// BrandserviceFanscountQueryResponse.
    /// </summary>
    public class BrandserviceFanscountQueryResponse : TopResponse
    {
        /// <summary>
        /// 返回粉丝个数
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
