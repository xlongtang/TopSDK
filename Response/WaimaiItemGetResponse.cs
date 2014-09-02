using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiItemGetResponse.
    /// </summary>
    public class WaimaiItemGetResponse : TopResponse
    {
        /// <summary>
        /// 外卖宝贝详情
        /// </summary>
        [XmlElement("result")]
        public TopAuction Result { get; set; }
    }
}
