using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiShopListResponse.
    /// </summary>
    public class WaimaiShopListResponse : TopResponse
    {
        /// <summary>
        /// 数据结果集
        /// </summary>
        [XmlElement("result")]
        public TakeoutShopPage Result { get; set; }
    }
}
