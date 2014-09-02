using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiShopBusinessrulesGetResponse.
    /// </summary>
    public class WaimaiShopBusinessrulesGetResponse : TopResponse
    {
        /// <summary>
        /// 外卖店铺信息
        /// </summary>
        [XmlElement("result")]
        public TakeoutOption Result { get; set; }
    }
}
