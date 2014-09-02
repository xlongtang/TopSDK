using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiShopOpenResponse.
    /// </summary>
    public class WaimaiShopOpenResponse : TopResponse
    {
        /// <summary>
        /// 成功：0，失败：1
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }
    }
}
