using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// DdReservedListResponse.
    /// </summary>
    public class DdReservedListResponse : TopResponse
    {
        /// <summary>
        /// 订单列表翻页对象
        /// </summary>
        [XmlElement("result")]
        public DdTopPagination Result { get; set; }
    }
}
