using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// DdTakeoutExportResponse.
    /// </summary>
    public class DdTakeoutExportResponse : TopResponse
    {
        /// <summary>
        /// 外卖店铺信息
        /// </summary>
        [XmlElement("result")]
        public DianDianShopPage Result { get; set; }
    }
}
