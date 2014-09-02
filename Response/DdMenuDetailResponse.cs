using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// DdMenuDetailResponse.
    /// </summary>
    public class DdMenuDetailResponse : TopResponse
    {
        /// <summary>
        /// 点菜单订单详情
        /// </summary>
        [XmlElement("result")]
        public DdTopMenuDetailVO Result { get; set; }
    }
}
