using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// DdStoreExportResponse.
    /// </summary>
    public class DdStoreExportResponse : TopResponse
    {
        /// <summary>
        /// 淘点点店铺分页信息
        /// </summary>
        [XmlElement("result")]
        public DianDianShopPage Result { get; set; }
    }
}
